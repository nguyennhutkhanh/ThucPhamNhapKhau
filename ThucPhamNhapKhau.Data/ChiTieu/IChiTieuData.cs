using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.ChiTieu
{
    public interface IChiTieuData
    {
        /// <summary>
        /// Lấy danh sách chỉ tiêu
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        List<HashValue> ChiTieuGetList();
    }
}
