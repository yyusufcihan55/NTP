using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Kademesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinif;
            sinif = Convert.ToInt32(comboBox1.Text);
            if (sinif > 0 && sinif < 5)
            {
                MessageBox.Show("ilkokul kademesi");
            }
            else if (sinif > 4 && sinif < 9)
            {
                MessageBox.Show("ortaokul kademesi");
            }
            else if (sinif > 8 && sinif < 13)
            {
                MessageBox.Show("lise kademesi");
            }
            else 
            {
                MessageBox.Show("htalı giriş");
            }
        }
    }
}
