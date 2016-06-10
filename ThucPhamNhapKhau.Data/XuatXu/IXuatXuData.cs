using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.XuatXu
{
    public interface IXuatXuData
    {
        /// <summary>
        /// Lấy danh sách quốc gia
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        List<HashValue> XuatXuGetList();
    }
}
