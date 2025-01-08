using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehliyet_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("ehliyet alabilirsiniz");
            }
            else 
            {
                MessageBox.Show("yaşınız tutmuyor");
            }
        }
    }
}
