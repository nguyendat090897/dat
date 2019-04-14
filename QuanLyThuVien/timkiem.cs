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
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();

        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void timkiem_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text + ":";

            if (comboBox1.SelectedItem == "NGAYNHAP")
            {
                textBox1.Clear();
                textBox1.Mask = "00/00/0000";
                
            }
            else if (comboBox1.SelectedItem == "NAMXB")
            {
                textBox1.Clear();
                textBox1.Mask = "0000";
            
            }
            else
            {
                textBox1.Mask = "";
                textBox1.Text = "";
            }

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            string cbbox = comboBox1.Text;
            string txtbox = textBox1.Text;
           //sea.search_1(cbbox, txtbox);
            cls.LoadData2DataGridView(dataGridView1, sea.search_1(cbbox, txtbox));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            maskedTextBox1.Text = "";
            if (maskedTextBox2.Text =="" && sea.search_2("MASACH", textBox2.Text) == "" && sea.search_2("TENSACH", textBox3.Text) == "" && sea.search_2("TENTG", textBox4.Text) == ""
                && sea.search_2("TENNXB", textBox5.Text) == "" && sea.search_2("MALINHVUC", textBox7.Text) == ""  && sea.search_2("NGAYNHAP", maskedTextBox1.Text) == "")
            {
                DateTime now = DateTime.Now;
                maskedTextBox2.Text = now.Year.ToString();
                DateTime.ParseExact(maskedTextBox2.Text, "yyyy", null);
            };
            if (maskedTextBox1.Text == "" && maskedTextBox2.Text == "" && sea.search_2("MASACH", textBox2.Text) == "" && sea.search_2("TENSACH", textBox3.Text) == "" && sea.search_2("TENTG", textBox4.Text) == ""
                && sea.search_2("TENNXB", textBox5.Text) == "" && sea.search_2("MALINHVUC", textBox7.Text) == "" )
            {

                maskedTextBox1.Text = "15042019";
               // DateTime.ParseExact(maskedTextBox1.Text, "dd/mm/yyyy", null);
            };

            if (sea.search_2("MASACH", textBox2.Text)=="" && sea.search_2("TENSACH", textBox3.Text) == "" && sea.search_2("TENTG", textBox4.Text) == "" 
                && sea.search_2("TENNXB", textBox5.Text) == "" && sea.search_2("MALINHVUC", textBox7.Text) == "" && sea.search_2("NAMXB", maskedTextBox2.Text) == ""
                && sea.search_2("NGAYNHAP", maskedTextBox1.Text) == "");
   
            {
            cls.LoadData2DataGridView(dataGridView2, "select*from tblSach where MASACH like'%" + textBox2.Text 
                + "%'and TENSACH like'%" + textBox3.Text + "%'and TENTG like'%" + textBox4.Text + "%'and TENNXB like'%" + textBox5.Text 
                + "%'and MaLv like'%" + textBox7.Text + "%'and NAMXB like '%" + maskedTextBox2.Text + "%' and NGAYNHAP like '%"  + maskedTextBox1.Text + "%'");
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
