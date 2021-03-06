
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_HoSo_GetHoSoByID')
   exec('CREATE PROCEDURE [dbo].[SP_HoSo_GetHoSoByID] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 03/06/2016
-- Description:	SP_HoSo_GetHoSoByID
-- =============================================
alter PROCEDURE SP_HoSo_GetHoSoByID
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	select ID, idctyxk, idctynk, sohopdong, ngay_hopdong = CONVERT(varchar(10), ngay_hopdong, 103), sotkhq, ngaytkhq,
		sodangky, ngay_dangky = CONVERT(varchar(10),ngay_dangky, 103), idnhomhang, maudich, idxuatxu, hansudung = CONVERT(varchar(10),hansudung, 103), 
		iddonvitinh, soluong, NW, GW, giatrilohang, ngaylaymau = CONVERT(varchar(10),ngaylaymau, 103), diadiemlaymau,
		chiphidangky, sophieuthu, sochungthu, ngaycapchungthu = CONVERT(varchar(10),ngaycapchungthu, 103)
	from tblLoHang 
	where ID = @ID
END
