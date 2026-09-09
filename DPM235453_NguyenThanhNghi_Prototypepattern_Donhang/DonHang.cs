using System;

namespace DPM235453_NguyenThanhNghi_Prototypepattern_Donhang
{
    public class DonHang : ICloneable
    {
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SanPham { get; set; }
        public int SoLuong { get; set; }
        public string DiaChi { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void HienThi()
        {
            Console.WriteLine("Ma don hang: " + MaDonHang);
            Console.WriteLine("Ten khach hang: " + TenKhachHang);
            Console.WriteLine("San pham: " + SanPham);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Dia chi: " + DiaChi);
        }
    }
}