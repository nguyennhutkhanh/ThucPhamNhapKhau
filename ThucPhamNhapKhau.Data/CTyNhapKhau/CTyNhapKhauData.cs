using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.CTyNhapKhau
{
    public class CTyNhapKhauData : BaseCmdExec, ICTyNhapKhauData
    {
        public CTyNhapKhauData(string strConn) : base(strConn) { }

        public List<HashValue> CTyNhapKhauGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_CongTyNhapKhau_GetList", param).ToList();
        }

        public HashValue CTyNhapKhauGetDiaChi(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<HashValue>("SP_CongTyNhapKhau_GetDiaChi", param).FirstOrDefault();
        }
    }
}
