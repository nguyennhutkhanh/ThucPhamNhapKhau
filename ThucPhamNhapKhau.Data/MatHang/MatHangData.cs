using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
using ThucPhamNhapKhau.Model.NhanHoSo.Response;

namespace ThucPhamNhapKhau.Data.MatHang
{
    public class MatHangData : BaseCmdExec, IMatHangData
    {
        public MatHangData(string strConn) : base(strConn) { }

        public List<MatHangRes> MatHangGetListByIDLoHang(int ID)
        {

            object[] param = new object[] { ID };

            return base.ExecStoredProc<MatHangRes>("SP_MatHang_GetByIDLoHang", param).ToList();
        }

        public CUDMessage MatHangInsert(MatHangItem item)
        {
            object[] param = new object[] { item.idlohang, item.tenmathang, item.noisanxuat, item.soluong, item.khoiluong, item.giatrihanghoa, item.idloaikiemtra, item.socongbo };

            return base.ExecStoredProc<CUDMessage>("SP_MatHang_Insert", param).FirstOrDefault();
        }


        public CUDMessage MatHangUpdate(MatHangItem item)
        {
            object[] param = new object[] { item.ID, item.idlohang, item.tenmathang, item.noisanxuat, item.soluong, item.khoiluong, item.giatrihanghoa, item.idloaikiemtra, item.socongbo };

            return base.ExecStoredProc<CUDMessage>("SP_MatHang_Update", param).FirstOrDefault();
        }

        public CUDMessage MatHangDelete(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<CUDMessage>("SP_MatHang_Delete", param).FirstOrDefault();
        }


        public MatHangItem MatHangGetChiTietMatHang(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<MatHangItem>("SP_MatHang_GetMatHangByID", param).FirstOrDefault();
        }
    }
}
