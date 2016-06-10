using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Data.NhomHangHoa;
using ThucPhamNhapKhau.Library.DataAccess;
using ThucPhamNhapKhau.Model.Common;

namespace ThucPhamNhapKhau.Data.XuatXu
{
    public class XuatXuData : BaseCmdExec, IXuatXuData
    {
        public XuatXuData(string strConn) : base(strConn) { }

        public List<HashValue> XuatXuGetList()
        {
            object[] param = new object[] { };

            return base.ExecStoredProc<HashValue>("SP_QuocGia_GetList", param).ToList();
        }
    }
}
