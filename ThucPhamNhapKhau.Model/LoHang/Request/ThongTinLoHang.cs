using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.LoHang
{
    class HoSo
    {
        public int ID { get; set; }
        public int idctyxk { get; set; }
        public int idctynk { get; set; }
        public string sodangky { get; set; }
        public DateTime ngay_dangky { get; set; }
        public int idnhomhang { get; set; }
        public Boolean maudich { get; set; }
        public string xuatxu { get; set; }
        public int iddonvitinh { get; set; }
        public int soluong { get; set; }
        public int NW { get; set; }
        public int GW { get; set; }
        public int giatrilohang { get; set; }
        public DateTime ngaylaymau { get; set; }
        public string điaiemlaymau { get; set; }
        public int chiphidangky { get; set; }
        public int sophieuthu { get; set; }
        public string sochungthu { get; set; }
        public DateTime ngaycapchungthu { get; set; }
    }
}
