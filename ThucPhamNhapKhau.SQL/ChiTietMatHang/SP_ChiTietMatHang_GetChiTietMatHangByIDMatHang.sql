
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_ChiTietMatHang_GetChiTietMatHangByIDMatHang')
   exec('CREATE PROCEDURE [dbo].[SP_ChiTietMatHang_GetChiTietMatHangByIDMatHang] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 06/06/2016
-- Description:	SP_ChiTietMatHang_GetChiTietMatHangByIDMatHang
-- =============================================
alter PROCEDURE SP_ChiTietMatHang_GetChiTietMatHangByIDMatHang
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	select b.ID, tenmathang, b.soluong, b.NW, b.GW, b.lot_batch, xuatxu = c.tennuoc, ngaysx = convert(nvarchar(10), b.ngaysx, 103), hansudung = convert(nvarchar(10), b.hansudung, 103)
	from tblMatHang a, tblChiTietMatHang b, tblQuocGia c
	where a.ID = b.idmathang and b.idxuatxu = c.ID and a.ID = @ID
END
