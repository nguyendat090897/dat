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
    public partial class capnhatnhanvien : Form
    {
        public capnhatnhanvien()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();


        private void capnhatnhanvien_Load(object sender, EventArgs e)
        {
             
            cls.LoadData2DataGridView(dataGridView1,"select * from tblNhanVien where TAIKHOAN='"+Main.TenDN+"'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateEMP update = new UpdateEMP();
            string ten = txtNHANVIEN.Text;
            string dc = txtDiaChi.Text;
            string dt = txtSoDienThoai.Text;
            string em = txtEmail.Text;
            string per = textPer.Text;
            string age = textAge.Text;
            if (txtNHANVIEN.Text =="")
            {
                update.UpdateEmp(ten, dc, dt, em, per, age);
            }
            else if (update.UpdateEmp(ten, dc, dt, em, per, age) == true)
            {
                cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
                MessageBox.Show("Sửa thành công");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))
            {
                txtNHANVIEN.Clear();
                txtDiaChi.Clear();
                txtSoDienThoai.Clear();
                txtEmail.Clear();
                textPer.Clear();
                textAge.Clear();
            }
            else
                txtNHANVIEN.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
                txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); 
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
                textPer.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); ;
                textAge.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string strDelete = "delete from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'";
            //cls.ThucThiSQLTheoPKN(strDelete);
            //cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien where TAIKHOAN='" + Main.TenDN + "'");
            //MessageBox.Show("Xóa thành công");
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&ch!=8)
            {
                e.Handled = true;
            }
        }

        private void textAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
