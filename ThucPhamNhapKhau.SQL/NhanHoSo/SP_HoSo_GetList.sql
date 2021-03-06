
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_HoSo_GetList')
   exec('CREATE PROCEDURE [dbo].[SP_HoSo_GetList] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_HoSo_GetList
-- =============================================
alter PROCEDURE SP_HoSo_GetList
@pageSize int = null,
@pageIndex int = null
AS
BEGIN
	Set @pageSize = ISNull(@pageSize,10)
	Set @pageIndex = ISNull(@pageIndex,1)

	Declare @Start int
	Declare @End int

	Set @Start = ((@pageIndex - 1) * @pageSize) + 1
	Set @End = @Start + @pageSize - 1

	select ROW_NUMBER() OVER (ORDER BY a.ID DESC) AS ROWNUMBER, a.ID, b.tencty as tenctyxk, c.tencty as tenctynk, sohopdong, ngay_hopdong = CONVERT(varchar(10),ngay_hopdong,103),
		sotkhq, ngaytkhq = CONVERT(varchar(10),ngaytkhq, 103), sodangky, ngay_dangky = CONVERT(varchar(10),ngay_dangky, 103), tennhom as tennhomhang, maudich, 
		tennuoc as xuatxu, hansudung = CONVERT(varchar(10),hansudung, 103), sovandon, ngay_vandon = CONVERT(varchar(10),ngay_vandon, 103), tendonvitinh as donvitinh, 
		soluong, NW, GW, giatrilohang, cuakhaudi = (select tencuakhau from tblCuaKhau where tblCuaKhau.ID = a.idcuakhaudi), 
		cuakhauden = (select tencuakhau from tblCuaKhau where tblCuaKhau.ID = a.idcuakhauden), ngaylaymau = CONVERT(varchar(10),ngaylaymau, 103),
		diadiemlaymau, ngayguimau = CONVERT(varchar(10),ngayguimau, 103), chiphidangky, motavandekiemtra, ketqua, sophieuthu, sochungthu, ngaycapchungthu = CONVERT(varchar(10),ngaycapchungthu, 103) into #temp
	from tblLoHang a, tblCTyXuatKhau b, tblCTyXuatKhau c, tblQuocGia d, tblDonViTinh e, tblNhomHang f
	where a.idctyxk = b.ID and a.idctynk = c.ID and a.idxuatxu = d.ID and a.iddonvitinh = e.ID and a.idnhomhang = f.ID

	select * from #temp where ROWNUMBER between @Start and @End

END
