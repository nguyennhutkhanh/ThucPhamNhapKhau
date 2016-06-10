using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChiTietMatHang.Request
{
    public class ChiTietMatHangItem
    {
        public int ID { get; set; }
        public int idmathang { get; set; }
        public float soluong { get; set; }
        public float NW { get; set; }
        public float GW { get; set; }
        public string lot_batch { get; set; }
        public int idxuatxu { get; set; }
        public DateTime ngaysx { get; set; }
        public DateTime hansudung { get; set; }
    }
}
