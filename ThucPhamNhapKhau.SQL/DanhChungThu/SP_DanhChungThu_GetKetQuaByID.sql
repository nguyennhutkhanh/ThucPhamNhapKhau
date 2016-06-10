
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_DanhChungThu_GetKetQuaByID')
   exec('CREATE PROCEDURE [dbo].[SP_DanhChungThu_GetKetQuaByID] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 08/06/2016
-- Description:	SP_DanhChungThu_GetKetQuaByID
-- =============================================
alter PROCEDURE SP_DanhChungThu_GetKetQuaByID
@ID int = null
AS
BEGIN
	Set @ID = ISNull(@ID,0)
	
	select ID, dat, lydokhongdat, bienphapxuly
	from tblMatHang
	where ID = @ID

END
