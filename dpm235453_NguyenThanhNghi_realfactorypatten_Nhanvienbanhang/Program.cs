using dpm235453_NguyenThanhNghi_realfactorypatten_Nhanvienbanhang;
using System;

class Program
{
    static void Main(string[] args)
    {
        INhanVienBanHang nv1 =
            NhanVienBanHangFactory.TaoNhanVien("QUAY");

        INhanVienBanHang nv2 =
            NhanVienBanHangFactory.TaoNhanVien("ONLINE");

        nv1.BanHang();
        nv2.BanHang();

        Console.ReadLine();
    }
}