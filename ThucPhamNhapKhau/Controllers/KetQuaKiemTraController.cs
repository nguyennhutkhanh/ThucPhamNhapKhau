using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucPhamNhapKhau.Data;
using ThucPhamNhapKhau.Data.ChiTietMatHang;
using ThucPhamNhapKhau.Data.LoaiKiemTra;
using ThucPhamNhapKhau.Data.MatHang;
using ThucPhamNhapKhau.Data.NhanHoSo;
using ThucPhamNhapKhau.Data.XuatXu;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Request;

namespace ThucPhamNhapKhau.Controllers
{
    public class KetQuaKiemTraController : Controller
    {
        //
        // GET: /KetQuaKiemTra/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListLoaiKiemTra()
        {
            ILoaiKiemTraData db = new LoaiKiemTraData(Common.TPNK_ConnectionName);
            return Json(db.LoaiKiemTraGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListHoSo()
        {
            int pageIndex = Int32.Parse(Request["pageIndex"].ToString());
            int pageSize = Int32.Parse(Request["pageSize"].ToString());
            HoSoData db = new HoSoData(Common.TPNK_ConnectionName);
            return Json(db.HoSoGetListLoHang(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListMatHang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            MatHangData db = new MatHangData(Common.TPNK_ConnectionName);
            return Json(db.MatHangGetListByIDLoHang(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMatHangByID()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IMatHangData mh = new MatHangData(Common.TPNK_ConnectionName);
            return Json(mh.MatHangGetChiTietMatHang(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListChiTietMathang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IChiTietMatHangData chitiet = new ChiTietMatHangData(Common.TPNK_ConnectionName);
            return Json(chitiet.ChiTietMatHangGetListByIDMatHang(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListXuatXu()
        {
            XuatXuData db = new XuatXuData(Common.TPNK_ConnectionName);
            return Json(db.XuatXuGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertChiTietMatHang()
        {
            int idmathang = Int32.Parse(Request["idmathang"].ToString());
            float soluong = float.Parse(Request["soluong"].ToString());
            float nw = float.Parse(Request["nw"].ToString());
            float gw = float.Parse(Request["gw"].ToString());
            string lot_batch = Request["lot_batch"].ToString();
            int xuatxu = Int32.Parse(Request["xuatxu"].ToString());
            string ngaysanxuat = Request["ngaysanxuat"].ToString();
            string hansudung = Request["hansudung"].ToString();

            ChiTietMatHangItem item = new ChiTietMatHangItem();
            item.idmathang = idmathang;
            item.soluong = soluong;
            item.NW = nw;
            item.GW = gw;
            item.lot_batch = lot_batch;
            item.idxuatxu = xuatxu;
            item.ngaysx = ConvertDate.YearMonthDay(ngaysanxuat);
            item.hansudung = ConvertDate.YearMonthDay(hansudung);

            ChiTietMatHangData db = new ChiTietMatHangData(Common.TPNK_ConnectionName);
            return Json(db.ChiTietMatHangInsert(item), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateChiTietMatHang()
        {
            int ID = Int32.Parse(Request["ID"].ToString());
            int idmathang = Int32.Parse(Request["idmathang"].ToString());
            float soluong = float.Parse(Request["soluong"].ToString());
            float nw = float.Parse(Request["nw"].ToString());
            float gw = float.Parse(Request["gw"].ToString());
            string lot_batch = Request["lot_batch"].ToString();
            int xuatxu = Int32.Parse(Request["xuatxu"].ToString());
            string ngaysanxuat = Request["ngaysanxuat"].ToString();
            string hansudung = Request["hansudung"].ToString();

            ChiTietMatHangItem item = new ChiTietMatHangItem();
            item.ID = ID;
            item.idmathang = idmathang;
            item.soluong = soluong;
            item.NW = nw;
            item.GW = gw;
            item.lot_batch = lot_batch;
            item.idxuatxu = xuatxu;
            item.ngaysx = ConvertDate.YearMonthDay(ngaysanxuat);
            item.hansudung = ConvertDate.YearMonthDay(hansudung);

            ChiTietMatHangData db = new ChiTietMatHangData(Common.TPNK_ConnectionName);
            return Json(db.ChiTietMatHangUpdate(item), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteChiTietMatHang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IChiTietMatHangData hs = new ChiTietMatHangData(Common.TPNK_ConnectionName);
            return Json(hs.ChiTietMatHangDelete(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChiTietMatHangByID()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IChiTietMatHangData db = new ChiTietMatHangData(Common.TPNK_ConnectionName);
            return Json(db.ChiTietMatHangByID(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateMatHang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            int idlohang = Int32.Parse(Request["idlohang"].ToString());
            string tenmathang = Request["tenmathang"].ToString();
            string noisanxuat = Request["noisanxuat"].ToString();
            float soluong = float.Parse(Request["soluong"].ToString());
            float khoiluong = float.Parse(Request["khoiluong"].ToString());
            float giatrihanghoa = float.Parse(Request["giatrihanghoa"].ToString());
            int idloaikiemtra = Int32.Parse(Request["idloaikiemtra"].ToString());
            string socongbo = Request["socongbo"].ToString();

            MatHangItem mathang = new MatHangItem();
            mathang.ID = id;
            mathang.idlohang = idlohang;
            mathang.tenmathang = tenmathang;
            mathang.noisanxuat = noisanxuat;
            mathang.soluong = soluong;
            mathang.khoiluong = khoiluong;
            mathang.giatrihanghoa = giatrihanghoa;
            mathang.idloaikiemtra = idloaikiemtra;
            mathang.socongbo = socongbo;

            IMatHangData mh = new MatHangData(Common.TPNK_ConnectionName);
            return Json(mh.MatHangUpdate(mathang), JsonRequestBehavior.AllowGet);
        }
	}
}