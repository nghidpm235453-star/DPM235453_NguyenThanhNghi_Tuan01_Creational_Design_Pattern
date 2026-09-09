using System;

namespace DPM235453_NguyenThanhNghi_AbstractFactory
{
    public class KhuyenMaiDienTu : IKhuyenMai
    {
        public void HienThi()
        {
            Console.WriteLine("Khuyến mãi cho sản phẩm điện tử.");
        }
    }
}