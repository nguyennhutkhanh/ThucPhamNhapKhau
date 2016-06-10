using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChungThu
{
    public class ChungThuReq
    {
        public int ID { get; set; }
        public string sohopdong { get; set; }
        public DateTime ngay_hopdong { get; set; }
        public string sovandon { get; set; }
        public DateTime ngay_vandon { get; set; }
        public int idcuakhaudi { get; set; }
        public int idcuakhauden { get; set; }
    }
}
