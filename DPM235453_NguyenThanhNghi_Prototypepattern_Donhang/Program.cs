using System;

namespace DPM235453_NguyenThanhNghi_Prototypepattern_Donhang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DonHang donHangGoc = new DonHang();

            donHangGoc.MaDonHang = "DH001";
            donHangGoc.TenKhachHang = "Nguyen Van A";
            donHangGoc.SanPham = "Laptop";
            donHangGoc.SoLuong = 2;
            donHangGoc.DiaChi = "An Giang";

            DonHang donHangClone =
                (DonHang)donHangGoc.Clone();

            donHangClone.MaDonHang = "DH002";
            donHangClone.TenKhachHang = "Nguyen Van B";
            donHangClone.SoLuong = 3;
            donHangClone.DiaChi = "Can Tho";

            Console.WriteLine("=== DON HANG GOC ===");
            donHangGoc.HienThi();

            Console.WriteLine();

            Console.WriteLine("=== DON HANG SAO CHEP ===");
            donHangClone.HienThi();

            Console.ReadKey();
        }
    }
}