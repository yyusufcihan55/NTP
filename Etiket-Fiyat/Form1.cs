using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiket_Fiyat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int etiketfiyatı;
        double indirimFiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            etiketfiyatı = Convert.ToInt32(textBox1.Text);
            indirimFiyat = etiketfiyatı - etiketfiyatı * 10 / 100;
            label1.Text = indirimFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etiketfiyatı = Convert.ToInt32(textBox1.Text);
            indirimFiyat = etiketfiyatı - etiketfiyatı * 25 / 100;
            label1.Text = indirimFiyat.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            etiketfiyatı = Convert.ToInt32(textBox1.Text);
            indirimFiyat = etiketfiyatı - etiketfiyatı * 50 / 100;
            label1.Text = indirimFiyat.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            etiketfiyatı = Convert.ToInt32(textBox1.Text);
            indirimFiyat = etiketfiyatı - etiketfiyatı * 100 / 100;
            label1.Text = indirimFiyat.ToString();

        }
    }
}
