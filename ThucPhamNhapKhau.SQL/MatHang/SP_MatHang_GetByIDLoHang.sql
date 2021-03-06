
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_MatHang_GetByIDLoHang')
   exec('CREATE PROCEDURE [dbo].[SP_MatHang_GetByIDLoHang] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_MatHang_GetByIDLoHang
-- =============================================
alter PROCEDURE SP_MatHang_GetByIDLoHang
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)

	select b.ID, b.idlohang, b.tenmathang, b.noisanxuat, b.soluong, b.khoiluong, b.giatrihanghoa, b.sodangky, c.tenloai as loaikiemtra, b.dat, b.lydokhongdat, b.bienphapxuly, b.socongbo
	from tblLoHang a, tblMatHang b, tblLoaiKiemTra c
	where a.ID = b.idlohang and b.idloaikiemtra = c.ID and a.ID = @ID
END
