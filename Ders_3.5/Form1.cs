using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string message = txt_message.Text.Trim();
            int adet = Convert.ToInt32(txt_messagenumber.Text);
            lst_message.Items.Clear();
            for (int i = 1; i <=adet  ; i++)
            {
                MessageBox.Show(+i +" --" + message);
                
            }
        }
    }
}
