using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Proc;
namespace QuanLyThuVien
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        public static string tk,old, new1, new2;
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Main frm = new Main();
             tk = frm.TenDN_TC.ToString() ;
             old = textBox1.Text ;
             new1 = textBox2.Text;
             new2=  textBox3.Text;
            ChangedPass changed = new ChangedPass();
            if (changed.Changed_Pass(tk ,old, new1, new2) ==true);
            {
                this.Close();
            }
            //    string strUpdate = "Update tblNhanVien set MATKHAU='" + textBox2.Text + "'where MATKHAU='" + textBox1.Text + "'";
            //    cls.ThucThiSQLTheoKetNoi(strUpdate);
            //    MessageBox.Show("Đổi mật khẩu thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

    }
}
