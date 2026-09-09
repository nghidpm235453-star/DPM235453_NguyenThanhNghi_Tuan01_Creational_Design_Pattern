using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyBanHang quanLy = QuanLyBanHang.Instance;

            int luaChon;

            do
            {
                quanLy.HienThiMenu();

                int.TryParse(Console.ReadLine(), out luaChon);

                quanLy.XuLyLuaChon(luaChon);

            } while (luaChon != 4);
        }
    }
}