using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            lst_multiply.Items.Clear();
            int s = int.Parse(txt_number.Text); //string olan veriyi istenilen veriyi dönüştürür...
            lst_multiply.Items.Add(s + " Sayının çarpım tablosu");
            //lst_multiply.Items.Clear(); eğer buraya koyarsak hemen üzerindeki kod satırınıda silmiş olurduk bu sebeple privatın hemen altına yazılmalı
            for(int sayac=1; sayac<=10; sayac++)
            {
                lst_multiply.Items.Add(s + "*" + sayac + "=" + (s * sayac));
            }
        }
    }
}
