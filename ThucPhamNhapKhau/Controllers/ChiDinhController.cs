using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucPhamNhapKhau.Data;
using ThucPhamNhapKhau.Data.ChiTietMatHang;
using ThucPhamNhapKhau.Data.ChiTieu;
using ThucPhamNhapKhau.Data.DinhChiTieu;
using ThucPhamNhapKhau.Data.LoaiKiemTra;
using ThucPhamNhapKhau.Data.MatHang;
using ThucPhamNhapKhau.Data.NhanHoSo;
using ThucPhamNhapKhau.Model.MatHang.Request;

namespace ThucPhamNhapKhau.Controllers
{
    public class ChiDinhController : Controller
    {
        //
        // GET: /ChiDinh/
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

        public JsonResult InsertMatHang()
        {
            int idlohang = Int32.Parse(Request["idlohang"].ToString());
            string tenmathang = Request["tenmathang"].ToString();
            string noisanxuat = Request["noisanxuat"].ToString();
            float soluong = float.Parse(Request["soluong"].ToString());
            float khoiluong = float.Parse(Request["khoiluong"].ToString());
            float giatrihanghoa = float.Parse(Request["giatrihanghoa"].ToString());
            int idloaikiemtra = Int32.Parse(Request["idloaikiemtra"].ToString());
            string socongbo = Request["socongbo"].ToString();

            MatHangItem mathang = new MatHangItem();
            mathang.idlohang = idlohang;
            mathang.tenmathang = tenmathang;
            mathang.noisanxuat = noisanxuat;
            mathang.soluong = soluong;
            mathang.khoiluong = khoiluong;
            mathang.giatrihanghoa = giatrihanghoa;
            mathang.idloaikiemtra = idloaikiemtra;
            mathang.socongbo = socongbo;

            IMatHangData mh = new MatHangData(Common.TPNK_ConnectionName);
            return Json(mh.MatHangInsert(mathang), JsonRequestBehavior.AllowGet);
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

        public JsonResult DeleteMatHang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            
            IMatHangData mh = new MatHangData(Common.TPNK_ConnectionName);
            return Json(mh.MatHangDelete(id), JsonRequestBehavior.AllowGet);
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

        public JsonResult ListChiTieuMathang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IDinhChiTieuData data = new DinhChiTieuData(Common.TPNK_ConnectionName);
            return Json(data.ChiTieuMatHangGetList(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListChiTieu()
        {
            IChiTieuData data = new ChiTieuData(Common.TPNK_ConnectionName);
            return Json(data.ChiTieuGetList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertChiTieu()
        {
            int idchitiet = Int32.Parse(Request["idchitiet"].ToString());
            int idchitieu = Int32.Parse(Request["idchitieu"].ToString());
            IDinhChiTieuData data = new DinhChiTieuData(Common.TPNK_ConnectionName);
            return Json(data.ChiTieuMatHangInsert(idchitiet, idchitieu), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteChiTieu()
        {
            int idchitiet = Int32.Parse(Request["idchitiet"].ToString());
            int idchitieu = Int32.Parse(Request["idchitieu"].ToString());
            IDinhChiTieuData data = new DinhChiTieuData(Common.TPNK_ConnectionName);
            return Json(data.ChiTieuMatHangDelete(idchitiet, idchitieu), JsonRequestBehavior.AllowGet);
        }
	}
}