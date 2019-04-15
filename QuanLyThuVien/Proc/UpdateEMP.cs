using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuanLyThuVien.Proc
{
    public class UpdateEMP
    {
        public static string Quyen;
        public static string admin;
        public static string user;
        public bool Ischar(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (Char.IsNumber(c))
                    return false;
            }
            return true;
        }
        public bool isnumber(char pValue)
        {
                if (!char.IsDigit(pValue) && pValue != 8)
            { 
                    return true;
             
            }
            return false;
        }
        public bool UpdateEmp(string ten,string dc,string sdt, string email, string per, string age)
        {
            Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
           
            try
            {
                if (ten.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập chi tiết");
                }
                else if (email.Length > 40)
                {
                    MessageBox.Show("Không vượt quá 40 ký tự");
                    return false;
                }
                else if (sdt.Length  < 10 && sdt !="")
                    {
                        MessageBox.Show("Số điện thoại bé hơn 10 số");
                        return false;
                    }
                    else if (sdt.Length >12)
                    {
                        MessageBox.Show("Số điện thoại lớn hơn 12 số");
                        return false;
                    }
                else if(int.Parse(age) < 18 || int.Parse(age) > 55)
                    {
                        MessageBox.Show("sai tuổi");
                        return false;
                    }
                else if (Ischar(ten) == false)
                    {
                        MessageBox.Show("Họ và Tên phải là chữ");
                        return false;
                    }
                else if (ten.Length > 50)
                    {
                        MessageBox.Show("Tên quá dài hoặc quá ngắn");
                        return false;
                    }
                else if (dc.Length > 150)
                    {
                        MessageBox.Show("Địa chỉ lớn hơn 150 ký tự");
                        return false;
                    }
                else if (Ischar(per) == false)
                    {
                        MessageBox.Show("Phải là ký tự");
                        return false;
                    }
                else if (per.Length > 50)
                    {
                        MessageBox.Show("Chức vụ phải nhỏ hỏn 50 ký tự");
                        return false;
                    }
                else if (!string.IsNullOrEmpty(email))
                    {
                        
                       if  (isEmail(email) == false)
                        { 
                        MessageBox.Show("Sai định dạng email");
                        return false;
                        }
                       else
                        {
                            string strUpdate = "update tblNhanVien set TENNV='" + ten + "',DIACHI='" + dc + "',DIENTHOAI='" + sdt + "',EMAIL='" + email + "',ChucVu='" + per + "',Tuoi='" + age + "' where TAIKHOAN='" + Main.TenDN + "'";
                            cls.ThucThiSQLTheoKetNoi(strUpdate);
                            MessageBox.Show("Sửa thành công");
                            return true;
                        }
                    }
                else
                {
                    string strUpdate = "update tblNhanVien set TENNV='" + ten + "',DIACHI='" + dc + "',DIENTHOAI='" + sdt + "',EMAIL='" + email + "',ChucVu='" + per + "',Tuoi='" + age + "' where TAIKHOAN='" + Main.TenDN + "'";
                    cls.ThucThiSQLTheoKetNoi(strUpdate);
                        MessageBox.Show("Sửa thành công");
                    return true;
                }
            }
            catch
            { return false; }
            return false;
        }














        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public bool UpdateEmp2(string tentk, string mk, string qh, string tennv,
            string dc, string sdt, string email, string per, string age, int emailchange, int tentkchange)
        {
            Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
            Login log2 = new Login();
           
            Login log1 = new Login();
            object user1 = log1.layGiaTri("select top 1 [QUYENHAN] from [Library].[dbo].[tblNhanVien] p where p.QUYENHAN='user'");
            object admin1 = log1.layGiaTri("select top 1 [QUYENHAN] from [Library].[dbo].[tblNhanVien] p where p.QUYENHAN='admin'");
            user = Convert.ToString(user1);
            admin = Convert.ToString(admin1);
            if (qh =="admin")
                { 
            try
            {
                if (tentk.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập chi tiết");
                }
                if (email.Length > 40)
                    {
                        MessageBox.Show("Không vượt quá 40 ký tự");
                        return false;
                    }
                    else
                {
                    if ( tennv.Length >50)
                    {
                        MessageBox.Show("Tên quá dài hoặc quá ngắn");
                        return false;
                    }

                    if (qh == "admin" || qh=="user")
                    {
                        
                    }
                    else
                        {  
                            MessageBox.Show("Nhập sai định dạng về quyền hạn");
                        return false;
                        }
                      if (sdt.Length < 10 && sdt != "")
                        {
                            MessageBox.Show("Số điện thoại bé hơn 10 số");
                            return false;
                        }
                        else if (sdt.Length > 12)
                        {
                            MessageBox.Show("Số điện thoại lớn hơn 12 số");
                            return false;
                        }
                        else if(int.Parse(age) < 18 || int.Parse(age) > 55)
                    {
                        MessageBox.Show("sai tuổi");
                        return false;
                    }
                        else if (dc.Length >150)
                        {
                            MessageBox.Show("Địa chỉ lớn hơn 150 ký tự");
                            return false;
                        }

                        /*  if (isnumber(char.Parse(sdt)) == false )
                                          {
                                              MessageBox.Show("Không đúng định dạng số");
                                              return false;
                                          }*/
                        else if(emailchange == 1)
                    {
                           
                            if (!string.IsNullOrEmpty(email))
                            {
                               
                                Login log = new Login();
                                object Q1 = log.layGiaTri("select [EMAIL] from [Library].[dbo].[tblNhanVien] p where p.EMAIL='" + email + "'");
                                Quyen = Convert.ToString(Q1);
                                if (isEmail(email) == false)
                                {
                                    MessageBox.Show("Sai định dạng email");
                                    return false;
                                }
                                
                                if (!string.IsNullOrEmpty(Quyen))   
                                {
                                    MessageBox.Show("Email đã tồn tại!");
                                return false;
                                }
                                else
                                     {
                                         string strUpdate = "update tblNhanVien set TaiKhoan='" + tentk + "',MatKhau='" + mk + "',QUYENHAN='" + qh + "',TENNV='" + tennv + "',DIACHI='" + dc + "',DIENTHOAI='" + sdt + "',EMAIL='" + email + "',ChucVu='" + per + "',Tuoi='" + age + "' where TAIKHOAN='" + tentk + "'";
                                         cls.ThucThiSQLTheoKetNoi(strUpdate);
                                         return true;
                                     }
                                }
                    }
                        else if(Ischar(per)==false)
                        {
                            MessageBox.Show("Phải là ký tự");
                            return false;
                        }
                        else if(per.Length >50)
                        {
                            MessageBox.Show("Chức vụ phải nhỏ hỏn 50 ký tự");
                            return false;
                        }
                        else if(Ischar(tennv) == false)
                    {
                        MessageBox.Show("Họ và Tên phải là chữ");
                        return false;
                    }
                        else  if (tennv =="")
                    {
                        MessageBox.Show("Họ và tên không được để trống");
                        return false;
                    }
                        else if(mk.Length < 6 || mk.Length >30)
                    {
                        MessageBox.Show("Mật khẩu phải từ 6 ký tự và bé hơn 30 ké tự");
                        return false;
                    }
                    else
                    {
                        string strUpdate = "update tblNhanVien set TaiKhoan='" + tentk + "',MatKhau='" + mk + "',QUYENHAN='" + qh + "',TENNV='" + tennv + "',DIACHI='" + dc + "',DIENTHOAI='" + sdt + "',EMAIL='" + email + "',ChucVu='" + per + "',Tuoi='" + age + "' where TAIKHOAN='" + tentk + "'";
                        cls.ThucThiSQLTheoKetNoi(strUpdate);
                        MessageBox.Show("Sửa thành công");
                        return true;
                    }
                }
            }
            catch
            {
               
                return false;
            }
            return false;
        }
            MessageBox.Show("Không có đủ quyền hạn");
            return false;
           
        }
    }
}
