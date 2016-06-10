using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChiTieuMatHang.Response
{
    public class ChiTieuMatHangRes
    {
        public int ID { get; set; }
        public int idchitietmathang { get; set; }
        public int idchitieu { get; set; }
        public string tenchitieu { get; set; }
    }
}
