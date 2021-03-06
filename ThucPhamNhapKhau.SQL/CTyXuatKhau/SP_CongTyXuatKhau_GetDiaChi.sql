
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_CongTyXuatKhau_GetDiaChi')
   exec('CREATE PROCEDURE [dbo].[SP_CongTyXuatKhau_GetDiaChi] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 09/06/2016
-- Description:	SP_CongTyXuatKhau_GetDiaChi
-- =============================================
ALTER PROCEDURE SP_CongTyXuatKhau_GetDiaChi
	@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	Select Id, diachi as Name from tblCTyXuatKhau
	where ID = @ID
END
