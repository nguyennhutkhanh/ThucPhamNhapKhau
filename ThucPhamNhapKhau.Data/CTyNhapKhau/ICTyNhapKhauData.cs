using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.CTyNhapKhau
{
    public interface ICTyNhapKhauData
    {
        /// <summary>
        /// Lấy danh sách công ty nhập khẩu
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        List<HashValue> CTyNhapKhauGetList();

        /// <summary>
        /// Lấy địa chỉ công ty nhập khẩu
        /// </summary>
        /// <param name=""></param>
        /// <returns>HashValue</returns>
        HashValue CTyNhapKhauGetDiaChi(int ID);
    }
}
