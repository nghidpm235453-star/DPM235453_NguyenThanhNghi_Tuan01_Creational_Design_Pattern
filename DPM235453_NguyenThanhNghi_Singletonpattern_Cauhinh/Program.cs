using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern_Cauhinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CauHinhHeThong cauHinh = CauHinhHeThong.Instance;

            cauHinh.HienThi();

            Console.WriteLine();
            Console.WriteLine("Nhap ten cua hang moi:");
            cauHinh.TenCuaHang = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== CAU HINH SAU KHI CAP NHAT ===");

            CauHinhHeThong cauHinh2 = CauHinhHeThong.Instance;

            cauHinh2.HienThi();

            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}