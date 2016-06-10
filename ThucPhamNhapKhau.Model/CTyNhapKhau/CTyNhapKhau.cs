using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucPhamNhapKhau.Model.CTyNhapKhau
{
    [ProtoContract]
    public class CTyNhapKhau
    {
        [ProtoMember(1)]
        public int ID {get; set; }

        [ProtoMember(2)]
        public string tencty { get; set; }

        [ProtoMember(3)]
        public string diachi_1 { get; set; }

        [ProtoMember(4)]
        public string dienthoai_1 { get; set; }

        [ProtoMember(5)]
        public string fax_1 { get; set; }

        [ProtoMember(6)]
        public string email_1 { get; set; }

        [ProtoMember(7)]
        public string nguoichiutrachnhiem { get; set; }

        [ProtoMember(8)]
        public string diachi_2 { get; set; }

        [ProtoMember(9)]
        public string dienthoai_2 { get; set; }

        [ProtoMember(10)]
        public string fax_2 { get; set; }

        [ProtoMember(11)]
        public string email_2 { get; set; }
    }
}
