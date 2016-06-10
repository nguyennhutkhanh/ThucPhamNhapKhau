
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_CongTyXuatKhau_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_CongTyXuatKhau_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_CongTyXuatKhau_GetList
-- =============================================
ALTER PROCEDURE SP_CongTyXuatKhau_GetList
	
AS
BEGIN
	Select Id, tencty as Name from tblCTyXuatKhau
END
