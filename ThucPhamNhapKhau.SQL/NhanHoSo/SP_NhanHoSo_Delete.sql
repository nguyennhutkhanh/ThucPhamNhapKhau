
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_NhanHoSo_Delete')
   exec('CREATE PROCEDURE [dbo].[SP_NhanHoSo_Delete] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 05/06/2016
-- Description:	SP_NhanHoSo_Delete
-- =============================================
alter PROCEDURE SP_NhanHoSo_Delete
	@ID int = null
AS
BEGIN
	
BEGIN TRAN T1
 BEGIN TRY
	Set @ID = ISNULL(@ID,0)
	
	DELETE FROM tblLoHang WHERE ID = @ID
		
	 Select @ID as Id, 'success' as [Message];

 COMMIT TRAN T1
END TRY
BEGIN CATCH
 ROLLBACK TRAN T1
 PRINT ERROR_MESSAGE()
   
    SELECT -1 AS Id, ERROR_MESSAGE() AS [Message]

END CATCH

	
END
