using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Hesaplamalar : Form
    {
        public Hesaplamalar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 + Sayi2;
            MessageBox.Show("2 sayının Toplamı:" + Hesap.ToString());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 - Sayi2;
            MessageBox.Show("2 sayının Çıkarımı:" + Hesap.ToString());

        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 * Sayi2;
            MessageBox.Show("2 sayının Çarpımı:" + Hesap.ToString());

        }
        private void button4_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 / Sayi2;
            MessageBox.Show("2 sayının Bölümü:" + Hesap.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 - Sayi2;
            MessageBox.Show("2 SAyının çıkarımı:" + Hesap.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 + Sayi2;
            MessageBox.Show("2 SAyının toplamı:" + Hesap.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 / Sayi2;
            MessageBox.Show("2 SAyının bölümü:" + Hesap.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal Sayi1 = Convert.ToDecimal(txt_number1.Text);
            decimal Sayi2 = Convert.ToDecimal(txt_number2.Text);
            decimal Hesap = Sayi1 * Sayi2;
            MessageBox.Show("2 SAyının çarpımı:" + Hesap.ToString());
        }
    }
}
