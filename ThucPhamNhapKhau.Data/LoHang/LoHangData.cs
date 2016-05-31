using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Library.DataAccess;

namespace ThucPhamNhapKhau.Data.LoHang
{
    public class LoHangData: BaseCmdExec, ILoHangData
    {
        public LoHangData(string strConn) : base(strConn) { }


    }
}
