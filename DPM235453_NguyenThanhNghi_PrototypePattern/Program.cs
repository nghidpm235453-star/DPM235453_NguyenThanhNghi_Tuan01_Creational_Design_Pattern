using System;

namespace DPM235453_NguyenThanhNghi_PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo sản phẩm gốc
            SanPham sanPhamGoc = new SanPham();

            sanPhamGoc.MaSanPham = "SP001";
            sanPhamGoc.TenSanPham = "Laptop";
            sanPhamGoc.Gia = 15000000;
            sanPhamGoc.Loai = "Điện tử";

            Console.WriteLine("=== SẢN PHẨM GỐC ===");
            sanPhamGoc.HienThi();

            // Clone sản phẩm
            SanPham sanPhamClone =
                (SanPham)sanPhamGoc.Clone();

            sanPhamClone.MaSanPham = "SP002";
            sanPhamClone.TenSanPham = "Laptop Dell";

            Console.WriteLine();
            Console.WriteLine("=== SẢN PHẨM CLONE ===");
            sanPhamClone.HienThi();

            Console.ReadLine();
        }
    }
}