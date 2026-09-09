using System;

namespace DPM235453_NguyenThanhNghi_BuilderPattern
{
    public class DonHang
    {
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SanPham { get; set; }
        public int SoLuong { get; set; }
        public string DiaChi { get; set; }

        public void HienThi()
        {
            Console.WriteLine("=== THÔNG TIN ĐƠN HÀNG ===");
            Console.WriteLine("Mã đơn hàng: " + MaDonHang);
            Console.WriteLine("Khách hàng: " + TenKhachHang);
            Console.WriteLine("Sản phẩm: " + SanPham);
            Console.WriteLine("Số lượng: " + SoLuong);
            Console.WriteLine("Địa chỉ: " + DiaChi);
        }
    }
}