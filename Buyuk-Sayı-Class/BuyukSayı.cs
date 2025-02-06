using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyuk_Sayı_Class
{
    internal class BuyukSayı
    {
        public int BüyükSayiyiBul(int sayi1,int sayi2) 
        {
            string buyuksayi;
            int sonuc;
            if (sayi1 < sayi2)
            {
                sonuc = sayi2;
            }
            else 
            {
                sonuc = sayi1;
            }
            return sonuc;
        }
    }
}
