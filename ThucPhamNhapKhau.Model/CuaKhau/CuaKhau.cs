using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.CuaKhau
{
    [ProtoContract]
    public class CuaKhau
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string tencuakhau { get; set; }

        [ProtoMember(2)]
        public string mota { get; set; }

    }
}
