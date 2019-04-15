using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuanLyThuVien.Proc
{
    public class Create_Acc
    {
        public static string Quyen;
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        Login log = new Login();
        UpdateEMP up = new UpdateEMP();
        public bool Create(string tentk,string pass, string pass2)
        {
            object Q1 = log.layGiaTri("select [TaiKhoan] from [Library].[dbo].[tblNhanVien] p where p.TaiKhoan='" + tentk + "'");
            Quyen = Convert.ToString(Q1);
            if (tentk =="")
                MessageBox.Show("Tên tài khoản không được để trống");
            else if (Quyen == tentk)
                MessageBox.Show("Tên tài khoản đã sử dụng");
           /* else if (up.Ischar(tentk) == false)
            {
                MessageBox.Show("Họ và Tên phải là chữ");
                return false;
            }*/
            else
                  if (tentk.Length - 1 > 50)
                MessageBox.Show("Tên tài khoản quá dài");
            else
                      if (pass.Length   < 5)
                MessageBox.Show("Mật khẩu quá ngắn");
            else
                          if (pass2.Length - 1 > 30)
                MessageBox.Show("Mật khẩu quá dài");
            else
                              if (pass != pass2)
                MessageBox.Show("Password không trùng nhau");
            else
            {
                try
                {
                    cls.ThucThiSQLTheoPKN("insert into tblNhanVien(TAIKHOAN,MATKHAU,QUYENHAN)values('" + tentk + "','" + pass + "','user')");
                    MessageBox.Show("Tạo tài khoản thành công hãy cập nhật thông tin cho tài khoản");
                    return true;
                }
                catch { MessageBox.Show("Không thể tạo được tài khoản"); }
            }
            return false;
        }
    }
}
