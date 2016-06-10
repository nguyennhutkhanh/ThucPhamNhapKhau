using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Data.NhomHangHoa;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.NhomHangHoa
{
    public class NhomHangData : BaseCmdExec, INhomHangData
    {
        public NhomHangData(string strConn) : base(strConn) { }

        public List<HashValue> NhomHangHoaGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_NhomHang_GetList", param).ToList();
        }
    }
}
