using System;

namespace DPM235453_NguyenThanhNghi_Prototypepattern_Sanpham
{
    public class SanPham : ICloneable
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double Gia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void HienThi()
        {
            Console.WriteLine("Ma san pham: " + MaSanPham);
            Console.WriteLine("Ten san pham: " + TenSanPham);
            Console.WriteLine("Gia: " + Gia);
        }
    }
}