using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdörtgen_Class
{
    internal class dıkdortgen
    {
        private int a, b;
        public dıkdortgen(int a,int b) 
        {
            this.a = a;
            this.b = b;
        }
        public int alanhesapla() 
        {
            return a * b;
        }
        public int cevrehesapla() 
        {
            return 2*(a + b);
        }


    }
}
