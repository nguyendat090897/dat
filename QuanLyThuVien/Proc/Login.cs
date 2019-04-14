using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien;
using QuanLyThuVien.Properties;
namespace QuanLyThuVien.Proc
{
   public class Login 
    {
        public static string Quyen;
            public Object layGiaTri(string sql) //lay gia tri cua  cot dau tien trong bang 
                    {
                        SqlCommand sqlCommand;
                        SqlConnection Con;
                        Con = new SqlConnection();
                        Con.ConnectionString = @"Server = DESKTOP-ELAG1MV; " + "database=Library; Integrated Security = true";
                        Con.Open();
                        sqlCommand = new SqlCommand();
                        sqlCommand.CommandText = sql;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = Con;

                        //CHi can lay ve gia tri cua mot truong thoi thi dung pt nao ? - ExecuteScalar
                        Object obj = sqlCommand.ExecuteScalar(); //neu co loi thi phai xem lai cua lenh SQL o ben kia
                        return obj;
                        //Ket qua de dau ? - de trong obj

                    }
        public bool Lo_gin(string ten, string mk)
        {
            if (ten != "")
            {
                object Q = layGiaTri("select [QUYENHAN] from [Library].[dbo].[tblNhanVien] p where p.TaiKhoan='" + ten + "' and p.MatKhau='" + mk + "'");
                if (Q == null)
                {
                    return false; ;
                }
                else
                {
                    return true;
                }
            }
            else
                return false;

        }  
       
       public bool Permission(string ten,string mk)
        {
            object Q = layGiaTri("select [QUYENHAN] from [Library].[dbo].[tblNhanVien] p where p.TaiKhoan='" + ten + "' and p.MatKhau='" + mk + "'");
            Quyen = Convert.ToString(Q);
            int result;
            if (Quyen == "user")
            {
                return false;
            }
            if (Quyen == "admin")
            {
               return true;
            }
            return true;
        }
    }
}
