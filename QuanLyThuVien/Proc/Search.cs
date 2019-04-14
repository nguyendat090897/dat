using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace QuanLyThuVien.Proc
{
    public class Search
    {
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        public string search_1( string cbbox, string txtbox)
        {
            
            string d;
            d = " select * from tblSach";
            if (cbbox == "TENSACH")
            {
                if (txtbox.Length - 1 > 50)
                {
                    d = " select * from tblSach";
                }
                else if (txtbox.Length ==0)
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where (TENSACH like '%" + txtbox + "%' OR MASACH LIKE '%" + txtbox + "%')";
                }

            }
            else if (cbbox == "TENTG")
            {
                if (txtbox.Length - 1 > 30)
                {
                    d = " select * from tblSach";
                }
                else if (txtbox.Length == 0)
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where (TENTG like '%" + txtbox + "%' OR MATG LIKE '%" + txtbox + "%')";
                }

            }
            else if (cbbox == "TENNXB")
            {
                if (txtbox.Length - 1 > 30)
                {
                    d = " select * from tblSach";
                }
                else if (txtbox.Length == 0)
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where (MANXB like '%" + txtbox + "%' OR TENNXB LIKE '%" + txtbox + "%')";
                }
            }
            else if (cbbox == "MALINHVUC")
            {
                if (txtbox.Length - 1 > 10)
                {
                    d = " select * from tblSach";
                }
                else if (txtbox.Length == 0)
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where (MaLv like '%" + txtbox + "%')";
                }
            }
            else if (cbbox == "NAMXB")
            {
                CheckDate year = new CheckDate();
                if (year.Check_Year(txtbox) == "Năm không hợp lệ")
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where " + cbbox + " like '%" + year.Check_Year(txtbox) + "%'";
                }
            }
           
            else if (cbbox == "NGAYNHAP")
            {
                CheckDate date = new CheckDate();
                if (date.Check_Year(txtbox) == "Ngày không hợp lệ")
                {
                    d = " select * from tblSach";
                }
                else
                {
                    d = "select*from tblSach where " + cbbox + " like '%" + date.Check_Date(txtbox) + "%'";
                }
            }
            return d;
        }
        public string search_2(string txtbox, string txtbox2)
        {
            if (txtbox == "TENSACH")
            {
                if (txtbox2.Length - 1 > 50)
                {
                    MessageBox.Show("Tên sách không hợp lệ");
                    return "Tên sách không hợp lệ";
                }
            }
            else if (txtbox == "TENTG")
            {
                if (txtbox2.Length - 1 > 30)
                {
                    MessageBox.Show("Tên tác giả không hợp lệ");
                    return "Tên tác giả không hợp lệ";

                }
            }
            else if (txtbox == "TENNXB")
            {
                if (txtbox2.Length - 1 > 30)
                {
                    MessageBox.Show("Tên NXB không hợp lệ");
                    return "Tên NXB không hợp lệ";

                }
            }
            else if (txtbox == "MALINHVUC")
            {
                if (txtbox2.Length - 1 > 10)
                {
                    MessageBox.Show("Mã lĩnh vực không hợp lệ");
                    return "Mã lĩnh vực không hợp lệ";

                }
            }
            else if (txtbox == "NAMXB")
            {
                CheckDate year = new CheckDate();
                if (year.Check_Year(txtbox2) == "Năm không hợp lệ")
                {
                    MessageBox.Show(year.Check_Year(txtbox2));
                    return year.Check_Year(txtbox2);

                }
            }
            else if (txtbox == "NGAYNHAP")
            {
                CheckDate date = new CheckDate();
                if (date.Check_Year(txtbox2) == "Ngày không hợp lệ")
                {
                    MessageBox.Show(date.Check_Year(txtbox2));
                    return date.Check_Year(txtbox2);
                }
            }
            return "";
        }
    }
}
