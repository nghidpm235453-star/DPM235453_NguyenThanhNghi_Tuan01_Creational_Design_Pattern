using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern
{
    public class QuanLyBanHang
    {
        private static QuanLyBanHang instance;

        private QuanLyBanHang()
        {
        }

        public static QuanLyBanHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuanLyBanHang();
                }

                return instance;
            }
        }

        public void HienThiMenu()
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       QUAN LY BAN HANG");
            Console.WriteLine("        SINGLETON PATTERN");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Quan ly san pham");
            Console.WriteLine("2. Quan ly nhan vien");
            Console.WriteLine("3. Quan ly don hang");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("=================================");
            Console.Write("Nhap lua chon: ");
        }

        public void XuLyLuaChon(int luaChon)
        {
            Console.Clear();

            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("=== QUAN LY SAN PHAM ===");
                    Console.WriteLine("Dang quan ly san pham...");
                    break;

                case 2:
                    Console.WriteLine("=== QUAN LY NHAN VIEN ===");
                    Console.WriteLine("Dang quan ly nhan vien...");
                    break;

                case 3:
                    Console.WriteLine("=== QUAN LY DON HANG ===");
                    Console.WriteLine("Dang quan ly don hang...");
                    break;

                case 4:
                    Console.WriteLine("Thoat chuong trinh!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            if (luaChon != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                Console.ReadKey();
            }
        }
    }
}