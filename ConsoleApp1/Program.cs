using System;

namespace DPM235453_NguyenThanhNghi_Prototypepattern_Sanpham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SanPham sanPhamGoc = new SanPham();

            sanPhamGoc.MaSanPham = "SP001";
            sanPhamGoc.TenSanPham = "Laptop";
            sanPhamGoc.Gia = 15000000;

            SanPham sanPhamClone =
                (SanPham)sanPhamGoc.Clone();

            sanPhamClone.MaSanPham = "SP002";
            sanPhamClone.TenSanPham = "Laptop Dell";
            sanPhamClone.Gia = 18000000;

            Console.WriteLine("=== SAN PHAM GOC ===");
            sanPhamGoc.HienThi();

            Console.WriteLine();

            Console.WriteLine("=== SAN PHAM SAO CHEP ===");
            sanPhamClone.HienThi();

            Console.ReadKey();
        }
    }
}