
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTietMatHang_Update')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTietMatHang_Update] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_ChiTietMatHang_Update
-- =============================================
alter PROCEDURE SP_ChiTietMatHang_Update
	@ID int = null,
	@idmathang int = null,
	@soluong float = null,
	@NW float = null,
	@GW float = null,
	@lot_batch nvarchar(10) = null,
	@idxuatxu int = null,
	@ngaysx DateTime = null,
	@hansudung DateTime = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY
	
	Set @ID = ISNULL(@ID,0)
	Set @idmathang = ISNULL(@idmathang,0)
	Set @soluong = ISNULL(@soluong,0)
	Set @NW = ISNULL(@NW,0)
	Set @GW = ISNULL(@GW,0)
	Set @idxuatxu = ISNULL(@idxuatxu,0)

	UPDATE tblChiTietMatHang 
	SET idmathang = @idmathang, soluong = @soluong, NW = @NW, GW = @GW, lot_batch = @lot_batch, idxuatxu = @idxuatxu, ngaysx = @ngaysx, hansudung = @hansudung
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
