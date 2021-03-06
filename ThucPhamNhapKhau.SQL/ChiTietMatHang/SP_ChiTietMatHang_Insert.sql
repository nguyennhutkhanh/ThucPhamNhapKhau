
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTietMatHang_Insert')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTietMatHang_Insert] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_ChiTietMatHang_Insert
-- =============================================
alter PROCEDURE SP_ChiTietMatHang_Insert
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

	Declare @ID int = 0
	Set @idmathang = ISNULL(@idmathang,0)
	Set @soluong = ISNULL(@soluong,0)
	Set @NW = ISNULL(@NW,0)
	Set @GW = ISNULL(@GW,0)
	Set @idxuatxu = ISNULL(@idxuatxu,0)

	Insert into tblChiTietMatHang(idmathang, soluong, NW, GW, lot_batch, idxuatxu, ngaysx, hansudung)
	Values(@idmathang, @soluong, @NW, @GW, @lot_batch, @idxuatxu, @ngaysx, @hansudung)
	
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
