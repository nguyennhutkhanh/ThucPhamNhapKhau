using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucPhamNhapKhau.Data;
using ThucPhamNhapKhau.Data.ChungThu;
using ThucPhamNhapKhau.Data.CuaKhau;
using ThucPhamNhapKhau.Data.MatHang;
using ThucPhamNhapKhau.Data.NhanHoSo;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.ChungThu;

namespace ThucPhamNhapKhau.Controllers
{
    public class ChungThuController : Controller
    {
        //
        // GET: /ChungThu/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListCuaKhau()
        {
            ICuaKhauData db = new CuaKhauData(Common.TPNK_ConnectionName);
            return Json(db.CuaKhauGetList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListHoSo()
        {
            int pageIndex = Int32.Parse(Request["pageIndex"].ToString());
            int pageSize = Int32.Parse(Request["pageSize"].ToString());
            IHoSoData db = new HoSoData(Common.TPNK_ConnectionName);
            return Json(db.HoSoGetListLoHang(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListMatHang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IMatHangData db = new MatHangData(Common.TPNK_ConnectionName);
            return Json(db.MatHangGetListByIDLoHang(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetHoSoByID()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IChungThuData db = new ChungThuData(Common.TPNK_ConnectionName);
            return Json(db.ChungThuChiTieuLoHangByID(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateLohang()
        {
            int id = Int32.Parse(Request["id"].ToString());
            string sohopdong = Request["sohopdong"].ToString();
            string ngayhopdong = Request["ngayhopdong"].ToString();
            string sovandon = Request["sovandon"].ToString();
            string ngayvandon = Request["ngayvandon"].ToString();
            int idcuakhaudi = Int32.Parse(Request["idcuakhaudi"].ToString());
            int idcuakhauden = Int32.Parse(Request["idcuakhauden"].ToString());

            ChungThuReq item = new ChungThuReq();
            item.ID = id;
            item.sohopdong = sohopdong;
            item.ngay_hopdong = ConvertDate.YearMonthDay(ngayhopdong);
            item.sovandon = sovandon;
            item.ngay_vandon = ConvertDate.YearMonthDay(ngayvandon);
            item.idcuakhaudi = idcuakhaudi;
            item.idcuakhauden = idcuakhauden;

            IChungThuData db = new ChungThuData(Common.TPNK_ConnectionName);
            return Json(db.ChungThuUpdateLoHang(item), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMatHangByID()
        {
            int id = Int32.Parse(Request["id"].ToString());
            IChungThuData db = new ChungThuData(Common.TPNK_ConnectionName);
            return Json(db.GetMatHangByID(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateKetQua()
        {
            int id = Int32.Parse(Request["id"].ToString());
            string dat = Request["dat"].ToString();
            string lydokhongdat = Request["lydokhongdat"].ToString();
            string bienphapxuly = Request["bienphapxuly"].ToString();

            KetQua item = new KetQua();
            item.ID = id;
            item.dat = Boolean.Parse(dat);
            item.lydokhongdat = lydokhongdat;
            item.bienphapxuly = bienphapxuly;

            IChungThuData db = new ChungThuData(Common.TPNK_ConnectionName);
            return Json(db.ChungThuUpdateKetQua(item), JsonRequestBehavior.AllowGet);
        }
	}
}