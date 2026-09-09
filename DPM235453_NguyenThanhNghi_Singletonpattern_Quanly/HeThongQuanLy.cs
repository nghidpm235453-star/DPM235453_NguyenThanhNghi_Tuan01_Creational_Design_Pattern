using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern_Quanly
{
    public class HeThongQuanLy
    {
        private static HeThongQuanLy instance;

        private HeThongQuanLy()
        {
        }

        public static HeThongQuanLy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeThongQuanLy();
                }

                return instance;
            }
        }

        public void HienThiMenu()
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       HE THONG QUAN LY");
            Console.WriteLine("        SINGLETON PATTERN");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Quan ly san pham");
            Console.WriteLine("2. Quan ly khach hang");
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
                    Console.WriteLine("=== QUAN LY KHACH HANG ===");
                    Console.WriteLine("Dang quan ly khach hang...");
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