using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.LoaiKiemTra
{
    public class LoaiKiemTraData : BaseCmdExec, ILoaiKiemTraData
    {
        public LoaiKiemTraData(string strConn) : base(strConn) { }

        public List<HashValue> LoaiKiemTraGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_LoaiKiemTra_GetList", param).ToList();
        }
    }
}
