using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Response;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
namespace ThucPhamNhapKhau.Data.ChiTietMatHang
{
    public interface IChiTietMatHangData
    {

        /// <summary>
        /// Danh sách chi tiết mặt hàng theo ID mặt hàng hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<ChiTietMatHangRes></returns>
        List<ChiTietMatHangRes> ChiTietMatHangGetListByIDMatHang(int IDMatHang);

        /// <summary>
        /// Thêm mới một chi tiết mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage ChiTietMatHangInsert(ChiTietMatHangItem item);

        /// <summary>
        /// Cập nhật chi tiết mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage ChiTietMatHangUpdate(ChiTietMatHangItem item);

        /// <summary>
        /// Xóa mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage ChiTietMatHangDelete(int ID);

        /// <summary>
        /// Chi tiết mặt hàng theo ID
        /// </summary>
        /// <param name=""></param>
        /// <returns>ChiTietMatHangItem</returns>
        ChiTietMatHangItemRes ChiTietMatHangByID(int ID);
    }
}
