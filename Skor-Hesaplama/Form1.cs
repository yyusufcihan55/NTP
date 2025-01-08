using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skor_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int skor1, skor2;
            skor1 = Convert.ToInt32(textBox1.Text);
            skor2 = Convert.ToInt32(textBox2.Text);
            if (skor1 > skor2)
            {
                MessageBox.Show("1. takım galip ");
            }
            else 
            {
                MessageBox.Show("2. takım galip");
            }
        }
    }
}
