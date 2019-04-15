using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Proc
{
    public class Update_BookInf
    {
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        CheckDate date =new CheckDate();
        public bool Update_Bookinfs(string MASACH, string TENSACH, string MATG, string MANXB, string MALv, string NAMXB, string SOTRANG, string SOLUONG, string NGAYNHAP, string GHICHU)
        { 
         try
            {
                if (MASACH.Length < 5)
                { MessageBox.Show("Mã sách quá ngắn");
                    return false; }
                else if (MASACH=="")
                {
                    MessageBox.Show("Mã sách không hợp lệ");
                    return false;
                }
                else if (MASACH.Length > 11)
                {
                    MessageBox.Show("Mã sách quá dài");
                    return false;
                }
                else if (TENSACH.Length < 5)
                {
                    MessageBox.Show("Tên sách quá ngắn");
                    return false;
                }
                else if (TENSACH.Length >100)
                {
                    MessageBox.Show("Tên sách quá dài");
                    return false;
                }
                else if (TENSACH =="")
                {
                    MessageBox.Show("Tên sách không hợp lệ");
                    return false;
                }
                else if ( date.Check_Year(NAMXB) == "Năm không hợp lệ")
                {
                    MessageBox.Show("Năm không hợp lệ");
                    return false;
                }
                else if (Convert.ToInt16(NAMXB) <1900)
                {
                    MessageBox.Show("Sách đã quá hạn");
                    return false;
                }
                else if (Convert.ToInt16(NAMXB) > 2019)
                {
                    MessageBox.Show("Sách quá hư cấu");
                    return false;
                }
                else if (Convert.ToInt16(SOTRANG) <=0)
                {
                    MessageBox.Show("Sách không đọc được phát lào");
                    return false;
                }
                string strInsert = "Insert Into tblSach(MASACH,TENSACH,MATG,MANXB,MALv,NAMXB,SOTRANG,SOLUONG,NGAYNHAP,GHICHU) values ('" + MASACH + "','" + TENSACH + "','" + MATG + "','" + MANXB + "','" + MALv + "','" + NAMXB + "','" + SOTRANG + "','" + SOLUONG + "','" + NGAYNHAP + "','" + GHICHU + "')";
                cls.ThucThiSQLTheoPKN(strInsert);
                MessageBox.Show("Thêm thành công");
                return true;
            }
            catch
            {
                MessageBox.Show("Trùng mã");
                return false; 
            }
            MessageBox.Show("Trùng mã");
            return false;
        }
        public bool changed_book(string MASACH, string TENSACH, string MATG, string MANXB, string MALv,string NAMXB, string SOTRANG, string SOLUONG, string NGAYNHAP, string GHICHU)
        {try
            { 
            string strUpdate = "Update tblSach set MASACH='"+MASACH+"',TENSACH='"+ TENSACH+ "',MATG='"+ MATG+ "',MANXB='" +MANXB+ "',MaLv='"+ MALv+ "',NAMXB='" +NAMXB+"',SOTRANG='"+SOTRANG+"',SOLUONG='" +SOLUONG +"',NGAYNHAP='"+ NGAYNHAP +"',GHICHU='" + GHICHU + "' where MASACH='" + MASACH + "'";
            cls.ThucThiSQLTheoPKN(strUpdate);
                MessageBox.Show("Sửa thành công");
            return true;
            }
            catch
            {
                MessageBox.Show("Sửa không thành công");
                return false;
            }
            MessageBox.Show("Sửa không thành công");
            return false;
        }
    }
}
