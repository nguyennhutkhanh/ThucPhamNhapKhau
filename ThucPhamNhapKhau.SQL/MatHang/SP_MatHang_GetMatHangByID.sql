
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_MatHang_GetMatHangByID')
   exec('CREATE PROCEDURE [dbo].[SP_MatHang_GetMatHangByID] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 06/06/2016
-- Description:	SP_MatHang_GetMatHangByID
-- =============================================
alter PROCEDURE SP_MatHang_GetMatHangByID
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	select ID, idlohang, tenmathang, noisanxuat, soluong, khoiluong, giatrihanghoa, idloaikiemtra, socongbo
	from tblMatHang 
	where ID = @ID
END
