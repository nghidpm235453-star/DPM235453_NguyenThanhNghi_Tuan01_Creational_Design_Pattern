using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern_Quanly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeThongQuanLy heThong = HeThongQuanLy.Instance;

            int luaChon;

            do
            {
                heThong.HienThiMenu();

                int.TryParse(Console.ReadLine(), out luaChon);

                heThong.XuLyLuaChon(luaChon);

            } while (luaChon != 4);
        }
    }
}