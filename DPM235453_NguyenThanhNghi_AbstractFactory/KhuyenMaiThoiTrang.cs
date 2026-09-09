using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    public class KhuyenMaiThoiTrang : IKhuyenMai
    {
        public void HienThi()
        {
            Console.WriteLine("Khuyến mãi cho sản phẩm thời trang.");
        }
    }
}