using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Response;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
using ThucPhamNhapKhau.Model.NhanHoSo.Response;

namespace ThucPhamNhapKhau.Data.ChiTietMatHang
{
    public class ChiTietMatHangData : BaseCmdExec, IChiTietMatHangData
    {
        public ChiTietMatHangData(string strConn) : base(strConn) { }

        public List<ChiTietMatHangRes> ChiTietMatHangGetListByIDMatHang(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<ChiTietMatHangRes>("SP_ChiTietMatHang_GetChiTietMatHangByIDMatHang", param).ToList();
        }

        public CUDMessage ChiTietMatHangInsert(ChiTietMatHangItem item)
        {
            object[] param = new object[] { item.idmathang, item.soluong, item.NW, item.GW, item.lot_batch, item.idxuatxu, item.ngaysx, item.hansudung };

            return base.ExecStoredProc<CUDMessage>("SP_ChiTietMatHang_Insert", param).FirstOrDefault();
        }

        public CUDMessage ChiTietMatHangUpdate(ChiTietMatHangItem item)
        {
            object[] param = new object[] {item.ID, item.idmathang, item.soluong, item.NW, item.GW, item.lot_batch, item.idxuatxu, item.ngaysx, item.hansudung };

            return base.ExecStoredProc<CUDMessage>("SP_ChiTietMatHang_Update", param).FirstOrDefault();
        }

        public CUDMessage ChiTietMatHangDelete(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<CUDMessage>("SP_ChiTietMatHang_Delete", param).FirstOrDefault();
        }

        public ChiTietMatHangItemRes ChiTietMatHangByID(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<ChiTietMatHangItemRes>("SP_ChiTietMatHang_GetChiTietMatHangByID", param).FirstOrDefault();
        }

    }
}
