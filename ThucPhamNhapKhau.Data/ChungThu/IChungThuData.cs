using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Request;
using ThucPhamNhapKhau.Model.ChiTietMatHang.Response;
using ThucPhamNhapKhau.Model.ChiTieuMatHang.Response;
using ThucPhamNhapKhau.Model.ChungThu;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.MatHang.Request;
using ThucPhamNhapKhau.Model.MatHang.Response;
namespace ThucPhamNhapKhau.Data.ChungThu
{
    public interface IChungThuData
    {

        /// <summary>
        /// Chi tiết lô hàng theo ID
        /// </summary>
        /// <param name=""></param>
        /// <returns>ChiTieuMatHangRes</returns>
        ChungThuRes ChungThuChiTieuLoHangByID(int ID);

        /// <summary>
        /// Cập nhật thông tin của lô hàng
        /// </summary>
        /// <param name=""></param>
        /// <returns>CUDMessage</returns>
        CUDMessage ChungThuUpdateLoHang(ChungThuReq item);

        /// <summary>
        /// Cập nhật kết quả
        /// </summary>
        /// <param name=""></param>
        /// <returns>CUDMessage</returns>
        CUDMessage ChungThuUpdateKetQua(KetQua item);

        /// <summary>
        /// Chi tiết mặt hàng theo ID
        /// </summary>
        /// <param name=""></param>
        /// <returns>KetQua</returns>
        KetQua GetMatHangByID(int ID);


    }
}
