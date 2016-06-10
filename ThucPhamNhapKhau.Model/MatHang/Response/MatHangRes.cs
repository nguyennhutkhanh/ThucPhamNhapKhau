using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.MatHang.Response
{
    public class MatHangRes
    {
        public int ID { get; set; }
        public int idlohang { get; set; }
        public string tenmathang { get; set; }
        public string noisanxuat { get; set; }
        public float soluong { get; set; }
        public float khoiluong { get; set; }
        public float giatrihanghoa { get; set; }
        public string sodangky { get; set; }
        public string loaikiemtra { get; set; }
        public bool dat { get; set; }
        public string lydokhongdat { get; set; }
        public string bienphapxuly { get; set; }
        public string socongbo { get; set; }
    }
}
