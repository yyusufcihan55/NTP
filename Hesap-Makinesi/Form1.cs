using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2;

        private void button2_Click(object sender, EventArgs e)
        {
            int çıkar;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            çıkar = sayi1 - sayi2;
            textBox3.Text = çıkar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int çarp;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            çarp = sayi1 * sayi2;
            textBox3.Text = çarp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kareal;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            kareal= sayi1 * sayi1;
            textBox3.Text = kareal.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int böl;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            böl = sayi1 / sayi2;
            textBox3.Text = böl.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int modal;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            modal = sayi1 % sayi2;
            textBox3.Text = modal.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox1.Text);
            topla = sayi1 + sayi2;
            textBox3.Text = topla.ToString();
        }
    }
}
