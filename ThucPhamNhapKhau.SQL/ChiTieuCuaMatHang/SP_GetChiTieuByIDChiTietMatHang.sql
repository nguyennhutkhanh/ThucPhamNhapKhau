
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_GetChiTieuByIDChiTietMatHang')
   exec('CREATE PROCEDURE [dbo].[SP_GetChiTieuByIDChiTietMatHang] AS BEGIN SET NOCOUNT ON; END')
GO
-- =============================================
-- Author:		Nhut Khanh
-- Create date: 07/06/2016
-- Description:	SP_GetChiTieuByIDChiTietMatHang
-- =============================================
alter PROCEDURE SP_GetChiTieuByIDChiTietMatHang
@ID int = null
AS
BEGIN
	set @ID = ISNULL(@ID, 0)
	select b.Id, b.idchitietmathang, b.idchitieu, tenchitieu
	from tblChiTietMatHang a, tblChiTieuMatHang b, tblChiTieu c
	where a.ID = b.idchitietmathang and b.idchitieu = c.id and a.ID = @ID
END
