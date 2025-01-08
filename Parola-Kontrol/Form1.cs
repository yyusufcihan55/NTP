using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parola_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = textBox1.Text;
            string hatakodu;

            if (string.IsNullOrEmpty(parola))
            {
                hatakodu = "101";
                MessageBox.Show("şifre boş bırakılmaz", "yanlış" + hatakodu, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (parola.Length < 8)
            {
                hatakodu = "102";
                MessageBox.Show("şifre en az 8 karakter olmalı", "yanlış" + hatakodu, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!parolaOzelKarakterIceriyormu(parola))
            {
                hatakodu = "103";
                MessageBox.Show("şifre özel karakter içermerli (#,@,! gibi)", "yanlış" + hatakodu, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("giriş başarılı","başarılı"+MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            textBox1.Clear();
        }
        private bool parolaOzelKarakterIceriyormu(string parola) 
        {
            string Ozelkarakt5erler
        }
    }
}
