using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.Common
{
    [ProtoContract]
    public class HashValue
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public object Name {get; set; }
    }

    public class ItemValue
    {
        public int Id { get; set; }
    }
}
