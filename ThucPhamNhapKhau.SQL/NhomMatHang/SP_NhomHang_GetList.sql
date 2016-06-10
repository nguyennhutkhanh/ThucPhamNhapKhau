
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_NhomHang_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_NhomHang_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_NhomHang_GetList
-- =============================================
ALTER PROCEDURE SP_NhomHang_GetList
	
AS
BEGIN
	Select Id, tennhom as Name from tblNhomHang
END
