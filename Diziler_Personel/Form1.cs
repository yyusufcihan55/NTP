using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Personel
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
        string[] personeller;
        int[] maaslar;
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            personeller = new string[] { "nisa", "murat", "kerim", "yusuf", "cihan", "ahmet", "arda", "ayşe", "nur", "mehmet" };
            maaslar = new int[] { 20000, 30000, 41000,50000,61000,80000,19000,70000,90000,100000 };
            for (int i = 0; i < personeller.Length; i++) 
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ararnan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++) 
            {
                if (ararnan == personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
                if (bulundu)
                {
                    MessageBox.Show("Personel Bulundu");
                }
                else 
                {
                    MessageBox.Show("Personel bulunamadı");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Toplam personel sayısı:" + personeller.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dusuk = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (dusuk > maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            label2.Text = "en düşük maaş:" + dusuk;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yuksek = maaslar[0];
            int yuksekindex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yuksek< maaslar[i])
                {
                    yuksek = maaslar[i];
                    yuksekindex = i;
                }
            }
            label2.Text = "en yüksek maaş:" + personeller[yuksekindex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < maaslar.Length; i++) 
            {
                if (maaslar[i] < 20000) 
                {
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0;i<maaslar.Length ; i++) 
            {
                if (maaslar[i] >= 50000 && maaslar[i] <= 100000) 
                {
                    sayac++;
                } 
            }
            label2.Text = "50k ile 100k olanlar arası" + sayac;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i = 0; i < maaslar.Length ; i++) 
            {
                toplam = maaslar[i];
            }
            label2.Text = "toplam ödenen maaş" + toplam;
        }
    }
}
