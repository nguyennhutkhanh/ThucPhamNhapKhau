
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_DanhChungThu_UpdateKetQua')
   exec('CREATE PROCEDURE [dbo].[SP_DanhChungThu_UpdateKetQua] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 08/06/2016
-- Description:	SP_DanhChungThu_UpdateKetQua
-- =============================================
alter PROCEDURE SP_DanhChungThu_UpdateKetQua
	@ID int = null,
	@dat bit = null,
	@lydokhongdat nvarchar(250) = null,
	@bienphapxuly nvarchar(MAX) = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY
	Set @ID = ISNULL(@ID,0)
	Set @dat = ISNULL(@dat,0)
	
	UPDATE tblMatHang SET dat = @dat, lydokhongdat = @lydokhongdat, bienphapxuly = @bienphapxuly
					WHERE ID = @ID
	
	 Select @ID as Id, 'success' as [Message];

 COMMIT TRAN T1
END TRY
BEGIN CATCH
 ROLLBACK TRAN T1
 PRINT ERROR_MESSAGE()
   
    SELECT -1 AS Id, ERROR_MESSAGE() AS [Message]

END CATCH

END
