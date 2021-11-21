using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_olc_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt_number.Text);
            int i = 0;
            int dividednumber = 2;
            while (true)
            {
                 if (sayi % dividednumber ==0  )
                {
                    i++;
                    break;
                }
                 if (i == 0) { }

                else()
            }
        }
    }
}
