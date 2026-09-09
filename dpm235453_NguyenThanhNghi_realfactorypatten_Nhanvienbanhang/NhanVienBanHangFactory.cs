using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpm235453_NguyenThanhNghi_realfactorypatten_Nhanvienbanhang
{
    public class NhanVienBanHangFactory
    {
        public static INhanVienBanHang TaoNhanVien(string loai)
        {
            if (loai == "QUAY")
            {
                return new NhanVienBanHangTaiQuay();
            }

            if (loai == "ONLINE")
            {
                return new NhanVienBanHangOnline();
            }

            return null;
        }
    }
}
