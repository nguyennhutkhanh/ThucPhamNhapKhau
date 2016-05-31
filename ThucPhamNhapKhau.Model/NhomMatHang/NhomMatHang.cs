using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.NhomMatHang
{
    [ProtoContract]
    public class NhomMatHang
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string tennhom { get; set; }

        [ProtoMember(3)]
        public string mota { get; set; }
    }
}
