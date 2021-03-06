
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_DanhChungThu_GetChungThuByIDLoHang')
   exec('CREATE PROCEDURE [dbo].[SP_DanhChungThu_GetChungThuByIDLoHang] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 08/06/2016
-- Description:	SP_DanhChungThu_GetChungThuByIDLoHang
-- =============================================
alter PROCEDURE SP_DanhChungThu_GetChungThuByIDLoHang
@ID int = null
AS
BEGIN
	Set @ID = ISNull(@ID,0)
	
	select ID, sohopdong, ngay_hopdong = convert(nvarchar(10), ngay_hopdong, 103), sovandon, ngay_vandon = convert(nvarchar(10),ngay_vandon, 103), idcuakhaudi, idcuakhauden
	from tblLoHang
	where ID = @ID

END
