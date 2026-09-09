namespace DPM235453_NguyenThanhNghi_BuilderPattern
{
    public class DonHangBuilder
    {
        private DonHang donHang;

        public DonHangBuilder()
        {
            donHang = new DonHang();
        }

        public DonHangBuilder SetMaDonHang(string ma)
        {
            donHang.MaDonHang = ma;
            return this;
        }

        public DonHangBuilder SetTenKhachHang(string ten)
        {
            donHang.TenKhachHang = ten;
            return this;
        }

        public DonHangBuilder SetSanPham(string sanPham)
        {
            donHang.SanPham = sanPham;
            return this;
        }

        public DonHangBuilder SetSoLuong(int soLuong)
        {
            donHang.SoLuong = soLuong;
            return this;
        }

        public DonHangBuilder SetDiaChi(string diaChi)
        {
            donHang.DiaChi = diaChi;
            return this;
        }

        public DonHang Build()
        {
            return donHang;
        }
    }
}