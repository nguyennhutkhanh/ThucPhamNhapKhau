using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.CTyXuatKhau
{
    public class CTyXuatKhauData : BaseCmdExec, ICTyXuatKhauData
    {
        public CTyXuatKhauData(string strConn) : base(strConn) { }

        public List<HashValue> CTyXuatKhauGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_CongTyXuatKhau_GetList", param).ToList();
        }

        public HashValue CTyXuatKhauGetDiaChi(int ID)
        {
            object[] param = new object[] { ID };

            return base.ExecStoredProc<HashValue>("SP_CongTyXuatKhau_GetDiaChi", param).FirstOrDefault();
        }
    }
}
