using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.CTyXuatKhau
{
    public interface ICTyXuatKhauData
    {
        /// <summary>
        /// Lấy danh sách công ty xuất khẩu
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<HashValue></returns>
        List<HashValue> CTyXuatKhauGetList();

        /// <summary>
        /// Lấy địa chỉ công ty xuất khẩu
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        HashValue CTyXuatKhauGetDiaChi(int ID);
    }
}
