using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.ChiTieu
{
    public class ChiTieuData : BaseCmdExec, IChiTieuData
    {
        public ChiTieuData(string strConn) : base(strConn) { }

        public List<HashValue> ChiTieuGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_ChiTieu_GetList", param).ToList();
        }

        
    }
}
