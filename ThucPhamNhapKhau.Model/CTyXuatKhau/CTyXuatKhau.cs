using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.LoHang
{
    [ProtoContract]
    public class CTyXuatKhau
    {
        [ProtoMember(1)]
        public int ID {get; set; }

        [ProtoMember(2)]
        public string tencty { get; set; }

        [ProtoMember(3)]
        public string diachi { get; set; }

        [ProtoMember(4)]
        public string dienthoai { get; set; }

        [ProtoMember(5)]
        public string fax { get; set; }

        [ProtoMember(6)]
        public string email { get; set; }
    }
}
