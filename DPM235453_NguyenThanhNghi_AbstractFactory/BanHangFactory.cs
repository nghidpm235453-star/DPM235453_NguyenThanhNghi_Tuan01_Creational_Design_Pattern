using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    public interface IBanHangFactory
    {
        ISanPham TaoSanPham();
        IKhuyenMai TaoKhuyenMai();
    }

    public class DienTuFactory : IBanHangFactory
    {
        public ISanPham TaoSanPham()
        {
            return new SanPhamDienTu();
        }

        public IKhuyenMai TaoKhuyenMai()
        {
            return new KhuyenMaiDienTu();
        }
    }

    public class ThoiTrangFactory : IBanHangFactory
    {
        public ISanPham TaoSanPham()
        {
            return new SanPhamThoiTrang();
        }

        public IKhuyenMai TaoKhuyenMai()
        {
            return new KhuyenMaiThoiTrang();
        }
    }
}