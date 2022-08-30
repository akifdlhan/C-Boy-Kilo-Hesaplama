using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boyKilo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double boy = 0, kilo = 0, vki = 0;
            kilo = Convert.ToDouble(txt_kilo.Text);
            boy=Convert.ToDouble(txt_boy.Text);
            vki=(kilo/(boy*boy));
            lbl_sonuc.Text += vki;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2500; i++)
            {
                this.Left += 7;
                this.Left -= 7;
            }
        }
    }
}
