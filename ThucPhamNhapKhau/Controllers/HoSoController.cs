using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucPhamNhapKhau.Data;
using ThucPhamNhapKhau.Data.CTyNhapKhau;
using ThucPhamNhapKhau.Data.CTyXuatKhau;
using ThucPhamNhapKhau.Data.DonViTinh;
using ThucPhamNhapKhau.Data.NhanHoSo;
using ThucPhamNhapKhau.Data.NhomHangHoa;
using ThucPhamNhapKhau.Data.XuatXu;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
namespace ThucPhamNhapKhau.Controllers
{
    public class HoSoController : Controller
    {
        //
        // GET: /HoSo/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListCongTyXuatKhau()
        {
            
            ICTyXuatKhauData db = new CTyXuatKhauData(Common.TPNK_ConnectionName);
            return Json(db.CTyXuatKhauGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CongTyXuatKhauGetDiaChi()
        {
            int id = Int32.Parse(Request["id"].ToString());
            ICTyXuatKhauData db = new CTyXuatKhauData(Common.TPNK_ConnectionName);
            return Json(db.CTyXuatKhauGetDiaChi(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListCongTyNhapKhau()
        {
            ICTyNhapKhauData db = new CTyNhapKhauData(Common.TPNK_ConnectionName);
            return Json(db.CTyNhapKhauGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CongTyNhapKhauGetDiaChi()
        {
            int id = Int32.Parse(Request["id"].ToString());
            ICTyNhapKhauData db = new CTyNhapKhauData(Common.TPNK_ConnectionName);
            return Json(db.CTyNhapKhauGetDiaChi(id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListNhomHangHoa()
        {
            INhomHangData db = new NhomHangData(Common.TPNK_ConnectionName);
            return Json(db.NhomHangHoaGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListXuatXu()
        {
            IXuatXuData db = new XuatXuData(Common.TPNK_ConnectionName);
            return Json(db.XuatXuGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListDonVi()
        {
            IDonViTinhData db = new DonViTinhData(Common.TPNK_ConnectionName);
            return Json(db.DonViTinhGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListHoSo()
        {
            int pageIndex = Int32.Parse(Request["pageIndex"].ToString());
            int pageSize = Int32.Parse(Request["pageSize"].ToString());
            IHoSoData db = new HoSoData(Common.TPNK_ConnectionName);
            return Json(db.HoSoGetListLoHang(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertHoSo()
        {
            int idctyxk = Int32.Parse(Request["idctyxk"].ToString());
            int idctynk = Int32.Parse(Request["idctynk"].ToString());
            string sodangky = Request["sodangky"].ToString();
            string ngaydangky = Request["ngaydangky"].ToString();
            bool maudich = Boolean.Parse(Request["maudich"].ToString());
            int idnhomhanghoa = Int32.Parse(Request["idnhomhanghoa"].ToString());
            int idxuatxu = Int32.Parse(Request["idxuatxu"].ToString());
            int iddonvi = Int32.Parse(Request["iddonvi"].ToString());
            float soluong = float.Parse(Request["soluong"].ToString());
            float nw = float.Parse(Request["nw"].ToString());
            float gw = float.Parse(Request["gw"].ToString());
            string giatrilohang = Request["giatrilohang"].ToString();
            string ngaylaymau = Request["ngaylaymau"].ToString();
            string diadiemlaymau = Request["diadiemlaymau"].ToString();
            string chiphidangky = Request["chiphidangky"].ToString();
            string sophieuthu = Request["sophieuthu"].ToString();
            string sochungthu = Request["sochungthu"].ToString();
            string ngaycap = Request["ngaycap"].ToString();

            HoSo hoso = new HoSo();
            hoso.idctyxk = idctyxk;
            hoso.idctynk = idctynk;
            hoso.sodangky = sodangky;
            hoso.ngay_dangky = ConvertDate.YearMonthDay(ngaydangky);
            hoso.maudich = maudich;
            hoso.idnhomhang = idnhomhanghoa;
            hoso.idxuatxu = idxuatxu;
            hoso.iddonvitinh = iddonvi;
            hoso.soluong = soluong;
            hoso.NW = nw;
            hoso.GW = gw;
            hoso.giatrilohang = Double.Parse(giatrilohang);
            hoso.ngaylaymau = ConvertDate.YearMonthDay(ngaylaymau);
            hoso.diadiemlaymau = diadiemlaymau;
            hoso.chiphidangky = Double.Parse(chiphidangky);
            hoso.sophieuthu = sophieuthu;
            hoso.sochungthu = sochungthu;
            hoso.ngaycapchungthu = ConvertDate.YearMonthDay(ngaycap);

            IHoSoData hs = new HoSoData(Common.TPNK_ConnectionName);
            return Json(hs.HoSoInsertNhanHoSo(hoso), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateHoSo()
        {
            int ID = Int32.Parse(Request["ID"].ToString());
            int idctyxk = Int32.Parse(Request["idctyxk"].ToString());
            int idctynk = Int32.Parse(Request["idctynk"].ToString());
            string sodangky = Request["sodangky"].ToString();
            string ngaydangky = Request["ngaydangky"].ToString();
            bool maudich = Boolean.Parse(Request["maudich"].ToString());
            int idnhomhanghoa = Int32.Parse(Request["idnhomhanghoa"].ToString());
            int idxuatxu = Int32.Parse(Request["idxuatxu"].ToString());
            int iddonvi = Int32.Parse(Request["iddonvi"].ToString());
            float soluong = float.Parse(Request["soluong"].ToString());
            float nw = float.Parse(Request["nw"].ToString());
            float gw = float.Parse(Request["gw"].ToString());
            string giatrilohang = Request["giatrilohang"].ToString();
            string ngaylaymau = Request["ngaylaymau"].ToString();
            string diadiemlaymau = Request["diadiemlaymau"].ToString();
            string chiphidangky = Request["chiphidangky"].ToString();
            string sophieuthu = Request["sophieuthu"].ToString();
            string sochungthu = Request["sochungthu"].ToString();
            string ngaycap = Request["ngaycap"].ToString();

            HoSo hoso = new HoSo();
            hoso.ID = ID;
            hoso.idctyxk = idctyxk;
            hoso.idctynk = idctynk;
            hoso.sodangky = sodangky;
            hoso.ngay_dangky = ConvertDate.YearMonthDay(ngaydangky);
            hoso.maudich = maudich;
            hoso.idnhomhang = idnhomhanghoa;
            hoso.idxuatxu = idxuatxu;
            hoso.iddonvitinh = iddonvi;
            hoso.soluong = soluong;
            hoso.NW = nw;
            hoso.GW = gw;
            hoso.giatrilohang = Double.Parse(giatrilohang);
            hoso.ngaylaymau = ConvertDate.YearMonthDay(ngaylaymau);
            hoso.diadiemlaymau = diadiemlaymau;
            hoso.chiphidangky = Double.Parse(chiphidangky);
            hoso.sophieuthu = sophieuthu;
            hoso.sochungthu = sochungthu;
            hoso.ngaycapchungthu = ConvertDate.YearMonthDay(ngaycap);

            IHoSoData hs = new HoSoData(Common.TPNK_ConnectionName);
            return Json(hs.HoSoUpdateNhanHoSo(hoso), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteHoSo()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IHoSoData hs = new HoSoData(Common.TPNK_ConnectionName);
            return Json(hs.HoSoDeleteNhanHoSo(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHoSoByID()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IHoSoData hs = new HoSoData(Common.TPNK_ConnectionName);
            return Json(hs.HoSoGetChiTietHoSo(id), JsonRequestBehavior.AllowGet);
        }
	}
}