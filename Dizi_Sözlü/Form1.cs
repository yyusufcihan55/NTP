using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_Sözlü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            notlar[index, 0] = Convert.ToInt32(txtSozlu1.Text);
            notlar[index, 1] = Convert.ToInt32(txtSozlu2.Text);
            notlar[index, 2] = Convert.ToInt32(txtSozlu3.Text);
            notlar[index, 3] = Convert.ToInt32(txtSozlu4.Text);

            for (int i = 0; i < index; i++)
            {
                listBox1.Items.Add("ad soyad:" + isimler[i]);
                for (int j = 0; j < i; j++) 
                {
                    listBox1.Items.Add(notlar[i, j]);
                }
            }
        }
    }
}
