
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_MatHang_Update')
   exec('CREATE PROCEDURE [dbo].[SP_MatHang_Update] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 05/06/2016
-- Description:	SP_MatHang_Update
-- =============================================
alter PROCEDURE SP_MatHang_Update
	@ID int = null,
	@idlohang int = null,
	@tenmathang nvarchar(250) = null,
	@noisanxuat nvarchar(250) = null,
	@soluong float = null,
	@khoiluong float = null,
	@giatrihanghoa float = null,
	@idloaikiemtra int = null,
	@socongbo nvarchar(100) = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY
	
	Set @ID = ISNULL(@ID,0)
	Set @idlohang = ISNULL(@idlohang,0)
	Set @soluong = ISNULL(@soluong,0)
	Set @khoiluong = ISNULL(@khoiluong,0)
	Set @giatrihanghoa = ISNULL(@giatrihanghoa,0)
	Set @idloaikiemtra = ISNULL(@idloaikiemtra,0)

	UPDATE tblMatHang 
	SET idlohang = @idlohang, tenmathang = @tenmathang, noisanxuat = @noisanxuat, soluong = @soluong, khoiluong = @khoiluong, giatrihanghoa = @giatrihanghoa, idloaikiemtra = @idloaikiemtra, socongbo = @socongbo
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
