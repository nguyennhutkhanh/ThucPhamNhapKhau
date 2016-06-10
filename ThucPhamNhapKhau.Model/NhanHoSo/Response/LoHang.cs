using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.NhanHoSo.Response
{
    public class LoHang
    {
        public int ID { get; set; }
        public string tenctyxk { get; set; }
        public string tenctynk { get; set; }
        public string sohopdong { get; set; }
        public string ngay_hopdong { get; set; }
        public string sotkhq { get; set; }
        public string ngaytkhq { get; set; }
        public string sodangky { get; set; }
        public string ngay_dangky { get; set; }
        public string tennhomhang { get; set; }
        public Boolean maudich { get; set; }
        public string xuatxu { get; set; }
        public string hansudung { get; set; }
        public string sovandon { get; set; }
        public string ngay_vandon { get; set; }
        public string donvitinh { get; set; }
        public float soluong { get; set; }
        public float NW { get; set; }
        public float GW { get; set; }
        public double giatrilohang { get; set; }
        public string cuakhaudi { get; set; }
        public string cuakhauden { get; set; }
        public string ngaylaymau { get; set; }
        public string diadiemlaymau { get; set; }
        public string ngayguimau { get; set; }
        public double chiphidangky { get; set; }
        public string motavandekiemtra { get; set; }
        public bool ketqua { get; set; }
        public string sophieuthu { get; set; }
        public string sochungthu { get; set; }
        public string ngaycapchungthu { get; set; }
    }
}
