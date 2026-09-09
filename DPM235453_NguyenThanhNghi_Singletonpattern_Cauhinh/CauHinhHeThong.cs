using System;

namespace DPM235453_NguyenThanhNghi_Singletonpattern_Cauhinh
{
    public class CauHinhHeThong
    {
        private static CauHinhHeThong instance;

        public string TenHeThong { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }

        private CauHinhHeThong()
        {
            TenHeThong = "He thong ban hang";
            TenCuaHang = "Cua hang ABC";
            DiaChi = "An Giang";
        }

        public static CauHinhHeThong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CauHinhHeThong();
                }

                return instance;
            }
        }

        public void HienThi()
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       CAU HINH HE THONG");
            Console.WriteLine("        SINGLETON PATTERN");
            Console.WriteLine("=================================");
            Console.WriteLine("Ten he thong: " + TenHeThong);
            Console.WriteLine("Ten cua hang: " + TenCuaHang);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("=================================");
        }
    }
}