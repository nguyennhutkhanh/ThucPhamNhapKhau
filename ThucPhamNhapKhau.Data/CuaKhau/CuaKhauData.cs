using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.CuaKhau
{
    public class CuaKhauData : BaseCmdExec, ICuaKhauData
    {
        public CuaKhauData(string strConn) : base(strConn) { }

        public List<HashValue> CuaKhauGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_CuaKhau_GetList", param).ToList();
        }
    }
}
