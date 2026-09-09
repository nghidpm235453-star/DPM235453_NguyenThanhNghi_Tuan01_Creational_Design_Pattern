using System;

namespace DPM235453_NguyenThanhNghi_PrototypePattern
{
    public class SanPham : ICloneable
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double Gia { get; set; }
        public string Loai { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void HienThi()
        {
            Console.WriteLine("Mã sản phẩm: " + MaSanPham);
            Console.WriteLine("Tên sản phẩm: " + TenSanPham);
            Console.WriteLine("Giá: " + Gia);
            Console.WriteLine("Loại: " + Loai);
        }
    }
}