
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTietMatHang_GetChiTietMatHangByID')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTietMatHang_GetChiTietMatHangByID] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_ChiTietMatHang_GetChiTietMatHangByID
-- =============================================
alter PROCEDURE SP_ChiTietMatHang_GetChiTietMatHangByID
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	select ID, idmathang, soluong, NW, GW, lot_batch, idxuatxu, ngaysx = convert(nvarchar(10), ngaysx, 103), hansudung = convert(nvarchar(10), hansudung, 103)
	from tblChiTietMatHang 
	where ID = @ID
END
