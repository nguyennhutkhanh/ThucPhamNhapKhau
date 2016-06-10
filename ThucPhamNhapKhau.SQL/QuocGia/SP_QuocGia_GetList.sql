
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_QuocGia_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_QuocGia_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_QuocGia_GetList
-- =============================================
ALTER PROCEDURE SP_QuocGia_GetList
	
AS
BEGIN
	Select Id, tennuoc as Name from tblQuocGia
END
