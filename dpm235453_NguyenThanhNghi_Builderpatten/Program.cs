using System;

namespace DPM235453_NguyenThanhNghi_BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DonHang donHang = new DonHangBuilder()
                .SetMaDonHang("DH001")
                .SetTenKhachHang("Nguyen Van A")
                .SetSanPham("Laptop")
                .SetSoLuong(2)
                .SetDiaChi("An Giang")
                .Build();

            donHang.HienThi();
           
            Console.ReadLine();
        }
    }
}