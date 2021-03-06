
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_CongTyNhapKhau_GetDiaChi')
   exec('CREATE PROCEDURE [dbo].[SP_CongTyNhapKhau_GetDiaChi] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 09/06/2016
-- Description:	SP_CongTyNhapKhau_GetDiaChi
-- =============================================
ALTER PROCEDURE SP_CongTyNhapKhau_GetDiaChi
	@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	Select Id, diachi_1 as Name from tblCtyNhapKhau
	where ID = @ID
END
