
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_DonViTinh_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_DonViTinh_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_DonViTinh_GetList
-- =============================================
ALTER PROCEDURE SP_DonViTinh_GetList
	
AS
BEGIN
	Select Id, tendonvitinh as Name from tblDonViTinh
END
