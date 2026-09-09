using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CUA HANG DIEN TU ===");

            IBanHangFactory dienTuFactory = new DienTuFactory();

            ISanPham sanPham1 = dienTuFactory.TaoSanPham();
            IKhuyenMai khuyenMai1 = dienTuFactory.TaoKhuyenMai();

            sanPham1.HienThi();
            khuyenMai1.HienThi();

            Console.WriteLine();

            Console.WriteLine("=== CUA HANG THOI TRANG ===");

            IBanHangFactory thoiTrangFactory =
                new ThoiTrangFactory();

            ISanPham sanPham2 = thoiTrangFactory.TaoSanPham();
            IKhuyenMai khuyenMai2 = thoiTrangFactory.TaoKhuyenMai();

            sanPham2.HienThi();
            khuyenMai2.HienThi();

            Console.ReadLine();
        }
    }
}