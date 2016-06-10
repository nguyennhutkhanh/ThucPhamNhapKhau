using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChungThu
{
    public class ChungThuRes
    {
        public int ID { get; set; }
        public string sohopdong { get; set; }
        public string ngay_hopdong { get; set; }
        public string sovandon { get; set; }
        public string ngay_vandon { get; set; }
        public int idcuakhaudi { get; set; }
        public int idcuakhauden { get; set; }
    }
}
