using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.DonViTinh
{
    public interface IDonViTinhData
    {
        /// <summary>
        /// Lấy danh sách đơn vị tính
        /// </summary>
        /// <param name=""></param>
        /// <returns>CTyXuatKhau</returns>
        List<HashValue> DonViTinhGetList();
    }
}
