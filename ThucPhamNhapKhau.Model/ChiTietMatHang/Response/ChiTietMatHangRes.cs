using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChiTietMatHang.Response
{
    public class ChiTietMatHangRes
    {
        public int ID { get; set; }
        public string tenmathang { get; set; }
        public float soluong { get; set; }
        public float NW { get; set; }
        public float GW { get; set; }
        public string lot_batch { get; set; }
        public string xuatxu { get; set; }
        public string ngaysx { get; set; }
        public string hansudung { get; set; }
    }
}
