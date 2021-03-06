
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_DanhChungThu_Update')
   exec('CREATE PROCEDURE [dbo].[SP_DanhChungThu_Update] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 08/06/2016
-- Description:	SP_DanhChungThu_Update
-- =============================================
alter PROCEDURE SP_DanhChungThu_Update
	@ID int = null,
	@sohopdong nvarchar(50) = null,
	@ngay_hopdong DateTime = null,
	@sovandon nvarchar(15) = null,
	@ngay_vandon DateTime = null,
	@idcuakhaudi int = null,
	@idcuakhauden int = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY
	Set @ID = ISNULL(@ID,0)
	Set @idcuakhaudi = ISNULL(@idcuakhaudi,0)
	Set @idcuakhauden = ISNULL(@idcuakhauden,0)

	UPDATE tblLoHang SET sohopdong = @sohopdong, ngay_hopdong = @ngay_hopdong, sovandon = @sovandon, ngay_vandon = @ngay_vandon, 
						 idcuakhaudi = @idcuakhaudi, idcuakhauden = @idcuakhauden
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
