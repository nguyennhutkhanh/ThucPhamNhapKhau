using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
namespace ThucPhamNhapKhau.Data.MatHang
{
    public interface IMatHangData
    {

        /// <summary>
        /// Danh sách mặt hàng theo ID lô hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<MatHangRes></returns>
        List<MatHangRes> MatHangGetListByIDLoHang(int IDLoHang);

        /// <summary>
        /// Thêm mới một mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage MatHangInsert(MatHangItem item);

        /// <summary>
        /// Cập nhật mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage MatHangUpdate(MatHangItem item);

        /// <summary>
        /// Xóa mặt hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage MatHangDelete(int ID);

        /// <summary>
        /// Chi tiết mặt hàng theo ID
        /// </summary>
        /// <param name=""></param>
        /// <returns>MatHangItem</returns>
        MatHangItem MatHangGetChiTietMatHang(int ID);
    }
}
