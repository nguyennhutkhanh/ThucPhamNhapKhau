using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
using ThucPhamNhapKhau.Model.NhanHoSo.Response;

namespace ThucPhamNhapKhau.Data.NhanHoSo
{
    public class HoSoData : BaseCmdExec, IHoSoData
    {
        public HoSoData(string strConn) : base(strConn) { }

        public CUDMessage HoSoInsertNhanHoSo(HoSo item)
        {

            object[] param = new object[] { item.idctyxk, item.idctynk, item.sodangky, item.ngay_dangky, item.idnhomhang, item.maudich, item.idxuatxu, item.iddonvitinh, item.soluong, item.NW,
                                            item.GW, item.giatrilohang, item.ngaylaymau, item.diadiemlaymau, item.chiphidangky, item.sophieuthu, item.sochungthu, item.ngaycapchungthu };

            return base.ExecStoredProc<CUDMessage>("SP_NhanHoSo_Insert", param).FirstOrDefault();
        }

        public CUDMessage HoSoUpdateNhanHoSo(HoSo item)
        {
            object[] param = new object[] { item.ID, item.idctyxk, item.idctynk, item.sodangky, item.ngay_dangky, item.idnhomhang, item.maudich, item.idxuatxu, item.iddonvitinh, item.soluong, item.NW,
                                            item.GW, item.giatrilohang, item.ngaylaymau, item.diadiemlaymau, item.chiphidangky, item.sophieuthu, item.sochungthu, item.ngaycapchungthu };

            return base.ExecStoredProc<CUDMessage>("SP_NhanHoSo_Update", param).FirstOrDefault();
        }

        public CUDMessage HoSoDeleteNhanHoSo(int ID){
            object[] param = new object[] { ID };

            return base.ExecStoredProc<CUDMessage>("SP_NhanHoSo_Delete", param).FirstOrDefault();
        }

        public List<LoHang> HoSoGetListLoHang(int pageIndex, int pageSize)
        {
            object[] param = new object[] { pageSize, pageIndex };

            return base.ExecStoredProc<ThucPhamNhapKhau.Model.NhanHoSo.Response.LoHang>("SP_HoSo_GetList", param).ToList();
        }

        public HoSoRes HoSoGetChiTietHoSo(int id)
        {
            object[] param = new object[] { id };

            return base.ExecStoredProc<HoSoRes>("SP_HoSo_GetHoSoByID", param).FirstOrDefault();
        }
    }
}
