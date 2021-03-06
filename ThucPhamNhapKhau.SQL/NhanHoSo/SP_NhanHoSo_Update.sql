
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_NhanHoSo_Update')
   exec('CREATE PROCEDURE [dbo].[SP_NhanHoSo_Update] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 05/06/2016
-- Description:	SP_NhanHoSo_Update
-- =============================================
alter PROCEDURE SP_NhanHoSo_Update
	@ID int = null,
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
	Set @ID = ISNULL(@ID,0)
	Set @idctyxk = ISNULL(@idctyxk,0)
	Set @idctynk = ISNULL(@idctynk,0)
	Set @idnhomhang = ISNULL(@idnhomhang,0)
	Set @iddonvitinh = ISNULL(@iddonvitinh,0)
	Set @soluong = ISNULL(@soluong,0.0)
	Set @NW = ISNULL(@NW,0.0)
	Set @GW = ISNULL(@GW,0.0)

	UPDATE tblLoHang SET idctyxk = @idctyxk, idctynk = @idctynk, sodangky = @sodangky, ngay_dangky = @ngay_dangky, 
						 idnhomhang = @idnhomhang, maudich = @maudich, idxuatxu = @idxuatxu, iddonvitinh = @iddonvitinh, 
						 soluong = @soluong, NW = @NW, GW = @GW, giatrilohang = @giatrilohang, ngaylaymau = @ngaylaymau, 
						 diadiemlaymau = @diadiemlaymau, chiphidangky = @chiphidangky, sophieuthu = @sophieuthu,
						 sochungthu = @sochungthu, ngaycapchungthu = @ngaycapchungthu
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
