
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_NhanHoSo_Insert')
   exec('CREATE PROCEDURE [dbo].[SP_NhanHoSo_Insert] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_NhanHoSo_Insert
-- =============================================
alter PROCEDURE SP_NhanHoSo_Insert
	@idctyxk int = null,
	@idctynk int = null,
	@sodangky nvarchar(30) = null,
	@ngay_dangky DateTime = null,
	@idnhomhang int = null,
	@maudich bit = null,
	@idxuatxu nvarchar(200),
	@iddonvitinh int = null,
	@soluong float = null,
	@NW float = null,
	@GW float = null,
	@giatrilohang Money = null,
	@ngaylaymau DateTime = null,
	@diadiemlaymau nvarchar(250) = null,
	@chiphidangky Money = null,
	@sophieuthu nvarchar(50) = null,
	@sochungthu nvarchar(50) = null,
	@ngaycapchungthu DateTime = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY

	Declare @ID int = 0
	Set @idctyxk = ISNULL(@idctyxk,0)
	Set @idctynk = ISNULL(@idctynk,0)
	Set @idnhomhang = ISNULL(@idnhomhang,0)
	Set @iddonvitinh = ISNULL(@iddonvitinh,0)
	Set @soluong = ISNULL(@soluong,0.0)
	Set @NW = ISNULL(@NW,0.0)
	Set @GW = ISNULL(@GW,0.0)

	Insert into tblLoHang(idctyxk, idctynk, sodangky, ngay_dangky, idnhomhang, maudich, idxuatxu, iddonvitinh, soluong,
						 NW, GW, giatrilohang, ngaylaymau, diadiemlaymau, chiphidangky, sophieuthu, sochungthu, ngaycapchungthu)
	Values(@idctyxk, @idctynk, @sodangky, @ngay_dangky, @idnhomhang, @maudich, @idxuatxu, @iddonvitinh, @soluong, @NW, @GW,
						 @giatrilohang, @ngaylaymau, @diadiemlaymau, @chiphidangky, @sophieuthu, @sochungthu, @ngaycapchungthu)
	

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
