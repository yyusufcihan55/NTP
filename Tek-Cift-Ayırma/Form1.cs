﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Cift_Ayırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 % 2 == 0)
            {
                MessageBox.Show("bu sayı çift tir");
            }
            if (sayi1 % 2 == 2) 
            {
                MessageBox.Show("bu sayı tek tir");
            }
        }
    }
}
