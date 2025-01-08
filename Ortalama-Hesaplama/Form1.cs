using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama;
            ortalama = Convert.ToInt32(textBox1.Text);
            if (ortalama > 70 && ortalama < 85) 
            {
                MessageBox.Show("teşekkür belgesi");
            }
            if (ortalama > 84 && ortalama < 100)
            {
                MessageBox.Show("takdir belgesi");
            }
            if (ortalama > 0 && ortalama < 49)
            {
                MessageBox.Show("kaldınız");
            }
            if (ortalama > 50 && ortalama < 70) 
            {
                MessageBox.Show("belgesiz");
            }
        }
    }
}
