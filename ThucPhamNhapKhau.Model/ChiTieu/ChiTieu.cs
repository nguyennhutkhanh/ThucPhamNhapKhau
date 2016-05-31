using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.ChiTieu
{
    [ProtoContract]
    public class ChiTieu
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string tenchitieu { get; set; }

        [ProtoMember(3)]
        public string MoTa { get; set; }
    }
}
