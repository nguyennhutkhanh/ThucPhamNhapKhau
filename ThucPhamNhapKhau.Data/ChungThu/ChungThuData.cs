using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.ChungThu;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.ChungThu
{
    public class ChungThuData : BaseCmdExec, IChungThuData
    {
        public ChungThuData(string strConn) : base(strConn) { }

        public ChungThuRes ChungThuChiTieuLoHangByID(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<ChungThuRes>("SP_DanhChungThu_GetChungThuByIDLoHang", param).FirstOrDefault();
        }

        public CUDMessage ChungThuUpdateLoHang(ChungThuReq item)
        {
            object[] param = new object[] { item.ID, item.sohopdong, item.ngay_hopdong, item.sovandon, item.ngay_vandon, item.idcuakhaudi, item.idcuakhauden };

            return base.ExecStoredProc<CUDMessage>("SP_DanhChungThu_Update", param).FirstOrDefault();
        }

        public CUDMessage ChungThuUpdateKetQua(KetQua item)
        {
            object[] param = new object[] { item.ID, item.dat, item.lydokhongdat, item.bienphapxuly};

            return base.ExecStoredProc<CUDMessage>("SP_DanhChungThu_UpdateKetQua", param).FirstOrDefault();
        }

        public KetQua GetMatHangByID(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<KetQua>("SP_DanhChungThu_GetKetQuaByID", param).FirstOrDefault();
        }

    }
}
