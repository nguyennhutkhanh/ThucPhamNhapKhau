using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucPhamNhapKhau.Model.Common;
using ThucPhamNhapKhau.Model.NhanHoSo.Request;
using ThucPhamNhapKhau.Model.NhanHoSo.Response;
namespace ThucPhamNhapKhau.Data.NhanHoSo
{
    public interface IHoSoData
    {
        /// <summary>
        /// Thêm mới một hồ sơ
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage HoSoInsertNhanHoSo(HoSo hoso);

        /// <summary>
        /// Cập nhật hồ sơ
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage HoSoUpdateNhanHoSo(HoSo hoso);

        /// <summary>
        /// Xóa hồ sơ
        /// </summary>
        /// <param name=""></param>
        /// <returns>{Id,Message}</returns>
        CUDMessage HoSoDeleteNhanHoSo(int ID);

        /// <summary>
        /// Danh sách hồ sơ
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<Lohang></returns>
        List<LoHang> HoSoGetListLoHang(int pageIndex, int pageSize);

        /// <summary>
        /// Chi tiết hồ sơ
        /// </summary>
        /// <param name=""></param>
        /// <returns>HoSo</returns>
        HoSoRes HoSoGetChiTietHoSo(int id);
    }
}
