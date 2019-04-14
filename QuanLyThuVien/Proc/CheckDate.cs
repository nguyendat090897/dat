using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyThuVien.Proc
{
    public class CheckDate
    {
        public string Check_Date(string text)
        {
            MaskedTextBox test = new MaskedTextBox();
            test.Text = text;
            if (test.MaskFull)
            {
                try
                {
                    DateTime.ParseExact(test.Text, "dd/MM/yyyy", null);
                    text = test.Text;
                    return text;
                }
                catch
                {
                    return "Ngày không hợp lệ";
                }
            }
            return text;
        }
        public string Check_Year(string text)
        {
            MaskedTextBox test = new MaskedTextBox();
            test.Text = text;
            if (test.MaskFull)
            {
                try
                {
                   DateTime.ParseExact(test.Text, "yyyy", null);
                    text = test.Text;
                    return text;
                }
                catch
                {
                    return "Năm không hợp lệ";
                }
            }
            return text;
        }
    }
}
