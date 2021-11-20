using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            decimal sayi1 = Convert.ToInt32(txt_number1.Text);
            decimal sayi2 = Convert.ToInt32(txt_number2.Text);
            decimal hesap_top = sayi1 + sayi2;
            if (hesap_top>50) 
            {
                MessageBox.Show("Girdiğiniz Sayı 50'den (" +hesap_top+" ) büyüktür.Geçtiniz...");
            }
            else if (hesap_top <30)
            {
                MessageBox.Show("Bütünlemeye Kaldınız....  ( " + hesap_top + " )");
            }
            
            else
            {
                MessageBox.Show("Sayınız 50'den küçüktür. ("+hesap_top+ " ) Kaldınız...");
            }
        }
    }
}
