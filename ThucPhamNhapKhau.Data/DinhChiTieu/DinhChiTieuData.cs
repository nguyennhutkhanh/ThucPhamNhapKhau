using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Response;
using ThucPhamNhapKhau.Model.ChiTieuMatHang.Response;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
using ThucPhamNhapKhau.Model.NhanHoSo.Response;

namespace ThucPhamNhapKhau.Data.DinhChiTieu
{
    public class DinhChiTieuData : BaseCmdExec, IDinhChiTieuData
    {
        public DinhChiTieuData(string strConn) : base(strConn) { }

        public List<ChiTieuMatHangRes> ChiTieuMatHangGetList(int IDChiTietMatHang)
        {
            object[] param = new object[] { IDChiTietMatHang };

            return base.ExecStoredProc<ChiTieuMatHangRes>("SP_GetChiTieuByIDChiTietMatHang", param).ToList();
        }

        public CUDMessage ChiTieuMatHangInsert(int idchitietmathang, int idchitieu)
        {
            object[] param = new object[] { idchitietmathang, idchitieu };

            return base.ExecStoredProc<CUDMessage>("SP_ChiTieuMatHang_Insert", param).FirstOrDefault();
        }

        public CUDMessage ChiTieuMatHangDelete(int idchitietmathang, int idchitieu)
        {
            object[] param = new object[] { idchitietmathang, idchitieu };

            return base.ExecStoredProc<CUDMessage>("SP_ChiTieuMatHang_Delete", param).FirstOrDefault();
        }
    }
}
