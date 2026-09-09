using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    public class SanPhamDienTu : ISanPham
    {
        public void HienThi()
        {
            Console.WriteLine("Sản phẩm điện tử.");
        }
    }
}