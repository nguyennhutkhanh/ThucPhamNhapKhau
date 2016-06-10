using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.CuaKhau
{
    public interface ICuaKhauData
    {
        /// <summary>
        /// Lấy danh sách cửa khẩu
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<HashValue></returns>
        List<HashValue> CuaKhauGetList();
    }
}
