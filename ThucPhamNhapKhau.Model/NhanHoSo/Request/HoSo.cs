using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.NhanHoSo.Request
{
    public class HoSo
    {
        public int ID { get; set; }
        public int idctyxk { get; set; }
        public int idctynk { get; set; }
        public string sodangky { get; set; }
        public DateTime ngay_dangky { get; set; }
        public int idnhomhang { get; set; }
        public Boolean maudich { get; set; }
        public int idxuatxu { get; set; }
        public int iddonvitinh { get; set; }
        public float soluong { get; set; }
        public float NW { get; set; }
        public float GW { get; set; }
        public double giatrilohang { get; set; }
        public DateTime ngaylaymau { get; set; }
        public string diadiemlaymau { get; set; }
        public double chiphidangky { get; set; }
        public string sophieuthu { get; set; }
        public string sochungthu { get; set; }
        public DateTime ngaycapchungthu { get; set; }
    }
}
