using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.NhanHoSo.Request
{
    public class KetQuaKiemTra
    {
        public int ID { get; set; }
        public DateTime hansudung { get; set; }
        public DateTime ngaylaymau { get; set; }
        public string diadiemlaymau { get; set; }
        public int chiphidangky { get; set; }
        public string motavandekiemtra { get; set; }
        public Boolean ketqua { get; set; }

        public List<KetQuaKiemTraItem> dsKetQuaKiemTraItem { get; set; }
    }

    public class KetQuaKiemTraItem
    {
        public int ID { get; set; }
        public int idmathang { get; set; }
        public int soluong { get; set; }
        public int NW { get; set; }
        public int GW { get; set; }
        public string lot_batch { get; set; }
        public string xuatxu { get; set; }
        public DateTime ngaysx { get; set; }
        public DateTime hansudung { get; set; }
    }
}
