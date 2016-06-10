using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Response;
using ThucPhamNhapKhau.Model.ChiTieuMatHang.Response;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
namespace ThucPhamNhapKhau.Data.DinhChiTieu
{
    public interface IDinhChiTieuData
    {

        /// <summary>
        /// Danh sách chỉ tiêu của từng mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<ChiTieuMatHangRes></returns>
        List<ChiTieuMatHangRes> ChiTieuMatHangGetList(int IDChiTietMatHang);

        /// <summary>
        /// Thêm chỉ tiêu cho mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>CUDMessage</returns>
        CUDMessage ChiTieuMatHangInsert(int idchitietmathang, int idchitieu);

        /// <summary>
        /// Xóa chỉ tiêu cho mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>CUDMessage</returns>
        CUDMessage ChiTieuMatHangDelete(int idchitietmathang, int idchitieu);
    }
}
