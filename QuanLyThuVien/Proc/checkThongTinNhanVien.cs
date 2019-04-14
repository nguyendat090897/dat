using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class checkThongTinNhanVien
    {
        public static string check_update_emp(string quyenHT, string tenNV, string matKhau, string quyenHan, string diaChi, string chucVu, int tuoi, string sdt)
        {
            if (quyenHT == "admin")
            {
                if (tenNV.Length <= 0)
                { return ("Không được để trống tên nhân viên"); }

                else
                    if (matKhau.Length <= 0)
                { return ("Không được để trống mật khẩu"); }
                else
                if (matKhau.Length <= 5)
                { return ("Mật khẩu ít nhất phải có 6 kí tự"); }
                else
                        if (quyenHan.Length - 1 <= 0)
                { return ("Không được để trống quyền hạn"); }
                else
                            if (diaChi.Length - 1 <= 0)
                { return ("Không được để trống địa chỉ"); }
                else
                                if (chucVu.Length - 1 <= 0)
                { return ("Không được để trống chức vụ"); }
                else
                                    if ((tuoi > 120) || (tuoi < 7))
                { return "Độ tuổi phải trong khoảng 7 đến 120"; }

                else
                if (sdt.Length != 10)
                { return ("Số điện thoại phải có 10 số"); }
                return "0";
            }
            { return "Bạn không có quyền chỉnh sửa và xóa"; }
        }

        public static string check_delete_emp(string quyen, string taikhoan)
        {
            if (quyen != "admin")
            { return ("Không thể xóa tài khoản admin"); }
            else return "0";

        }

    }
}
