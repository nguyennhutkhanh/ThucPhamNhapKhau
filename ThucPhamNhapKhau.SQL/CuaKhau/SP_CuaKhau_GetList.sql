
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_CuaKhau_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_CuaKhau_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 08/06/2016
-- Description:	SP_CuaKhau_GetList
-- =============================================
ALTER PROCEDURE SP_CuaKhau_GetList
	
AS
BEGIN
	Select Id, tencuakhau as Name from tblCuaKhau
END
