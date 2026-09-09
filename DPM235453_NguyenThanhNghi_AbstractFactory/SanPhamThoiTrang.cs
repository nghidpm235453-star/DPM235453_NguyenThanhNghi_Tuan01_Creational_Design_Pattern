using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    public class SanPhamThoiTrang : ISanPham
    {
        public void HienThi()
        {
            Console.WriteLine("Sản phẩm thời trang.");
        }
    }
}