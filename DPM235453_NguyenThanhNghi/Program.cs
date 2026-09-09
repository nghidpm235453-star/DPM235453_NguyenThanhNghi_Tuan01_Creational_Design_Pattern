using System;

namespace DPM235453_NguyenThanhNghi_realfactorypattern_Nhanvienbanhang
{
    // Factory
    abstract class NhanVienBanHangFactory
    {
        public abstract INhanVienBanHang FactoryMethod();

        public string SomeOperation()
        {
            var nhanVien = FactoryMethod();

            return "Factory tạo: " + nhanVien.BanHang();
        }
    }

    // Factory nhân viên tại quầy
    class FactoryNhanVienTaiQuay : NhanVienBanHangFactory
    {
        public override INhanVienBanHang FactoryMethod()
        {
            return new NhanVienBanHangTaiQuay();
        }
    }

    // Factory nhân viên online
    class FactoryNhanVienOnline : NhanVienBanHangFactory
    {
        public override INhanVienBanHang FactoryMethod()
        {
            return new NhanVienBanHangOnline();
        }
    }

    // Product
    public interface INhanVienBanHang
    {
        string BanHang();
    }

    // Concrete Product 1
    class NhanVienBanHangTaiQuay : INhanVienBanHang
    {
        public string BanHang()
        {
            return "Nhân viên bán hàng tại quầy";
        }
    }

    // Concrete Product 2
    class NhanVienBanHangOnline : INhanVienBanHang
    {
        public string BanHang()
        {
            return "Nhân viên bán hàng online";
        }
    }

    // Client
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Nhân viên bán hàng tại quầy:");
            ClientCode(new FactoryNhanVienTaiQuay());

            Console.WriteLine();

            Console.WriteLine("Nhân viên bán hàng online:");
            ClientCode(new FactoryNhanVienOnline());
        }

        public void ClientCode(NhanVienBanHangFactory factory)
        {
            Console.WriteLine(factory.SomeOperation());
        }
    }

    // Program
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();

            Console.ReadLine();
        }
    }
}