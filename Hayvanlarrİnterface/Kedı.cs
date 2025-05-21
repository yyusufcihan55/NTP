using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlarrİnterface
{
    internal class Kedı:Ibeslenme, ISes
    {
       public void Beslenme() 
       {
        Console.WriteLine("Kedi yemek yer");
       }
    public void ses() 
    {
        Console.WriteLine("Kedi ses çıkarır");
    }
  }
}
