using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_try_Click(object sender, EventArgs e)
        {
            string Renk = txt_write.Text.Trim();
            switch (Renk)
            {
                case "Kırmızı":
                MessageBox.Show("Bekle");
                    break;
                case "Sarı":
                    MessageBox.Show("Hazırlan");
                    break;
                case "Yeşil":
                    MessageBox.Show("Geç");
                    break;
                default:
                    MessageBox.Show("Girdiğiniz renk geçersizdir...");
                    break;
            }
        }
    }
}
