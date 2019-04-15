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
    public partial class capnhatsach : Form
    {
        public capnhatsach()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void capnhatsach_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
            cls.LoadData2Combobox(cboMATG, "select MATG from tblTacGia");
            cls.LoadData2Combobox(cboMANXB, "select MANXB from tblNXB");
            cls.LoadData2Combobox(cboMALv, "select MaLv from tblLinhVuc");
            cls.LoadData2Combobox(cbotenLV, "select TenLv from tblLinhVuc");
            cls.LoadData2Combobox(cbotenTG,"Select TENTG from tblTacGia");
            cls.LoadData2Combobox(cbotenNXB,"Select TENNXB from tblNXB");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMASACH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTENSACH.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboMATG.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboMANXB.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cboMALv.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtNAMXB.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtSOTRANG.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtSOLUONG.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtsachhong.Text ="";
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           string ms= txtMASACH.Text;
            string ts = txtTENSACH.Text;
            string tg = cboMATG.Text;
            string mnx = cboMANXB.Text;
            string mlv = cboMALv.Text;
            string nxb = txtNAMXB.Text;
            string st = txtSOTRANG.Text;
            string sl = txtSOLUONG.Text;
            string ngay = maskedTextBox1.Text;
            string gc = richTextBox1.Text;

            Update_BookInf book = new Update_BookInf();

            if (book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc) == true)
                cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
            else book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);       
       }

        int dem = 0;
        string masach;
        private void button2_Click(object sender, EventArgs e)
        {
            string ms = txtMASACH.Text;
            string ts = txtTENSACH.Text;
            string tg = cboMATG.Text;
            string mnx = cboMANXB.Text;
            string mlv = cboMALv.Text;
            string nxb = txtNAMXB.Text;
            string st = txtSOTRANG.Text;
            string sl = txtSOLUONG.Text;
            string ngay = maskedTextBox1.Text;
            string gc = richTextBox1.Text;

            if (dem == 0)
            {
                masach = txtMASACH.Text;
                dem = 1;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                Update_BookInf book = new Update_BookInf();
                if (book.changed_book(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc) == true)
                { 
                cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
                button1.Enabled = true;
                button3.Enabled = true;
                dem = 0;
                }
                else 
                 book.changed_book(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
                
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strDelete = "Delete from tblSach where MASACH='" + txtMASACH.Text + "'";
                cls.ThucThiSQLTheoKetNoi(strDelete);
                cls.LoadData2DataGridView(dataGridView1, "select *from tblSach");
                MessageBox.Show("Xóa thành công !!!");
            }
        }

        private void txtsachhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cbotenLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMALv.SelectedIndex = cbotenLV.SelectedIndex;
        }

        private void cboMALv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotenLV.SelectedIndex = cboMALv.SelectedIndex;
        }

        private void cbotenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMATG.SelectedIndex = cbotenTG.SelectedIndex;
        }

        private void cboMATG_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotenTG.SelectedIndex = cboMATG.SelectedIndex;
        }

        private void cbotenNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMANXB.SelectedIndex = cbotenNXB.SelectedIndex;
        }

        private void cboMANXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotenNXB.SelectedIndex = cboMANXB.SelectedIndex;
        }

    }
}
