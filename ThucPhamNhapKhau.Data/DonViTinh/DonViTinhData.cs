using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.DonViTinh
{
    public class DonViTinhData : BaseCmdExec, IDonViTinhData
    {
        public DonViTinhData(string strConn) : base(strConn) { }

        public List<HashValue> DonViTinhGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_DonViTinh_GetList", param).ToList();
        }
    }
}
