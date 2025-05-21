using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Dizi_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int satirsayisi;
        int sutunsayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            int dusuk = Convert.ToInt16(txtDusuk.Text);
            int yuksek = Convert.ToInt16(txtYuksek.Text);
            satirsayisi = Convert.ToInt16(txtSatırsayisi.Text);
            sutunsayisi = Convert.ToInt16(txtSutunsayisi.Text);

            dizi = new int[satirsayisi, sutunsayisi];
            Random rastgele = new Random();

            for (int x = 0; x < satirsayisi; x++) 
            {
                for (int y = 0; y < sutunsayisi; y++) 
                {
                    dizi[x, y] = rastgele.Next(dusuk, yuksek);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int x = 0;x < satirsayisi; x++) 
            {
                for (int y = 0; y < sutunsayisi; y++)
                {
                    listBox1.Items.Add(x + "," + y + "=>" + dizi[x, y]);

                }
            }
        }
    }
}
