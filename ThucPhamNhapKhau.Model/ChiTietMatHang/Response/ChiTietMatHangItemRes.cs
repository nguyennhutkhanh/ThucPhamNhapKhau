using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChiTietMatHang.Response
{
    public class ChiTietMatHangItemRes
    {
        public int ID { get; set; }
        public int idmathang { get; set; }
        public float soluong { get; set; }
        public float NW { get; set; }
        public float GW { get; set; }
        public string lot_batch { get; set; }
        public int idxuatxu { get; set; }
        public string ngaysx { get; set; }
        public string hansudung { get; set; }
    }
}
