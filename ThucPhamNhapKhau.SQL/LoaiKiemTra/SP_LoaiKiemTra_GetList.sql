
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_LoaiKiemTra_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_LoaiKiemTra_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 06/06/2016
-- Description:	SP_LoaiKiemTra_GetList
-- =============================================
ALTER PROCEDURE SP_LoaiKiemTra_GetList
	
AS
BEGIN
	Select Id, tenloai as Name from tblLoaiKiemTra
END
