using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlarrİnterface
{
    internal class Kopek:Ibeslenme,ISes
    {
        public void Beslenme() 
        {
            Console.WriteLine("Köpek yemek yer");
        }
        public void Ses() 
        {
            Console.WriteLine("Köpek Ses Çıkarır");
        }
    }
}
