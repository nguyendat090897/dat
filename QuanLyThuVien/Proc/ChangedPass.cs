using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Proc
{
    public class ChangedPass
    {
        public bool Changed_Pass(string tk,string passold, string passnew, string passnew2)
        {
            Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
            if (passnew.Length < 5)//kiểm tra mật khẩu mới xem co lờn hơn 6 ký tụ ko
                MessageBox.Show("mật khẩu mới quá ngắn");
            else
                if (passnew.Length  > 50)//kiểm tra mật khẩu mới xem có bé hơn 30 ký tụ ko
                    MessageBox.Show("mật khẩu mới quá dài");
                else
                    if (passnew != passnew2)//kiểm tra mật khẩu mới và xác nhận mk co trung nha
                        MessageBox.Show("mật khẩu mới không trùng hãy nhập lại");
                    else
                    if (Main.MatKhau !=null)
                            { 
                                if (passold != Main.MatKhau)//kiểm tra mật khẩu cũ
                                   MessageBox.Show("Mật khẩu cũ sai  hãy nhập lại mật khẩu");
                            }
                        else if (passold =="matkhausai")
                        {
                            if (passold != Main.MatKhau)//kiểm tra mật khẩu cũ
                                MessageBox.Show("Mật khẩu cũ sai  hãy nhập lại mật khẩu");
                        }
           else  if (passold =="")
                             {
                                MessageBox.Show("Mật khẩu không để trống");
                              }
                        else
                        {
                            try//thục hiên cau lệnh để thay đổi mật khẩu
                            {
                                string strUpdate = "Update tblNhanVien set MATKHAU='" + passnew + "'where MATKHAU='" + passold + "'and TAIKHOAN='" + tk + "'";
                                cls.ThucThiSQLTheoKetNoi(strUpdate);
                                MessageBox.Show("đổi mật khẩu thành công");
                                return true;
                }
                            catch (Exception E)
                            {
                                MessageBox.Show("" + E.ToString());
                                return false;
                            }
                        }
            return false;
        }
    }
}
