using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swicth_Case_Mevsim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mevsim = Convert.ToInt32(textBox1.Text);

            switch (mevsim) 
            {
                case 1:
                    this.BackColor = Color.Yellow;
                    MessageBox.Show("yaz");
                    break;
                case 2:
                    this.BackColor = Color.LightGreen;
                    MessageBox.Show("ilk bahar");
                    break;
                case 3:
                    this.BackColor = Color.Orange;
                    MessageBox.Show("son bahar");
                    break;
                case 4:
                    this.BackColor = Color.White;
                    MessageBox.Show("kış");
                    break;
                default:
                    MessageBox.Show("hata");
                    break;
            }
        }
    }
}
