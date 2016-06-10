using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.NhomHangHoa
{
    public interface INhomHangData
    {
        /// <summary>
        /// Lấy danh sách nhóm hàng hóa
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        List<HashValue> NhomHangHoaGetList();
    }
}
