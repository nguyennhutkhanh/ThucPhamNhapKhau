
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTieuMatHang_Delete')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTieuMatHang_Delete] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_ChiTieuMatHang_Delete
-- =============================================
alter PROCEDURE SP_ChiTieuMatHang_Delete
	@idchitietmathang int = null,
	@idchitieu int = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY

	Declare @ID int = 0
	Set @idchitietmathang = ISNULL(@idchitietmathang,0)
	Set @idchitieu = ISNULL(@idchitieu,0)
	
	DELETE from tblChiTieuMatHang
	WHERE idchitietmathang = @idchitietmathang and idchitieu = @idchitieu
	
	Set @ID = SCOPE_IDENTITY();

	Select @ID as Id, 'success' as [Message]

 COMMIT TRAN T1
END TRY
BEGIN CATCH
 ROLLBACK TRAN T1
 PRINT ERROR_MESSAGE()
   
    SELECT -1 AS Id, ERROR_MESSAGE() AS [Message]

END CATCH

	
END
