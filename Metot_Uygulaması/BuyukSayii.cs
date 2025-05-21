using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Uygulaması
{
    internal class BuyukSayii
    {
        public int buyuksayiyibul(int sayi1,int sayi2) 
        {
            int sonuç;
            if (sayi1 > sayi2)
            {
                sonuç = sayi2;
            }
            else
            {
                sonuç = sayi1;
            }
            return sonuç;
        }
    }
}
