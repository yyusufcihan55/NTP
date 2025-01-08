using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kare_Alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, karesi;
            sayi1 = Convert.ToInt32(textBox1.Text);
            karesi = sayi1 * sayi1;
            MessageBox.Show(karesi.ToString());
        }
    }
}
