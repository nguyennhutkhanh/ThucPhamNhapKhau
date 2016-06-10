
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTieu_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTieu_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_ChiTieu_GetList
-- =============================================
ALTER PROCEDURE SP_ChiTieu_GetList
	
AS
BEGIN
	Select Id, tenchitieu as Name from tblChiTieu
END
