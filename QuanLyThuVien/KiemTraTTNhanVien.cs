using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.Proc;


namespace QuanLyThuVien
{
    public partial class KiemTraTTNhanVien : Form
    {
        public static int emailchange = 0;
        public static int tentkchange = 0;
        public static string emailtext;
        public static string tentktext;
        UpdateEMP update = new UpdateEMP();
        public static bool a;
        public KiemTraTTNhanVien()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void KiemTraTTNhanVien_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select*from tblNhanVien"); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            emailtext = textBox7.Text;
            tentktext = textBox1.Text;
        }
        string TenTK;
        int Dem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string mk = textBox2.Text;
            string qh = textBox3.Text;
            string tennv = textBox4.Text;
            string dc = textBox5.Text;
            string dt = textBox6.Text;
            string email = textBox7.Text;
            string cv = textBox8.Text;
            string age = textBox9.Text;
            UpdateEMP update = new UpdateEMP();
            
            if (textBox7.Text != emailtext)
            {
                emailchange = 1;
               
            }
            
            a = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            
            switch (a == true)
                {
                case true:
                    {
                        cls.LoadData2DataGridView(dataGridView1, "select * from tblNhanVien");
                        emailchange= 0;
                        tentkchange= 0;
                        break;
                    }
            }
            emailchange = 0;
            tentkchange = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            if (textBox5.Text == "admin")
                MessageBox.Show("Không thể xóa tài khoản admin");
            else
                if (MessageBox.Show("Bạn có chắc chắn xóa thông tin nhân viên "+s,"Thông Báo Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string SQL = ("delete from tblNhanVien where TaiKhoan='" + textBox1.Text + "'");
                    cls.ThucThiSQLTheoKetNoi(SQL);
                    cls.LoadData2DataGridView(dataGridView1, "select*from tblNhanVien");
                    MessageBox.Show("Xóa thành công");
                }
                   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
  
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
