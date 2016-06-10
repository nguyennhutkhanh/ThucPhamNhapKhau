using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
namespace ThucPhamNhapKhau.Data.LoaiKiemTra
{
    public interface ILoaiKiemTraData
    {
        /// <summary>
        /// Lấy danh sách loại kiểm tra
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<HashValue></returns>
        List<HashValue> LoaiKiemTraGetList();
    }
}
