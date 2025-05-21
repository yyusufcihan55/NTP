using System.Collections;

namespace hhashtableUygg
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Hashtable ogrenciler = new Hashtable();

            ogrenciler.Add(43, "cihan");
            ogrenciler.Add("yusuf", 72);
            ogrenciler.Add("rüzgar",147);
            ogrenciler.Add("burak", 107);

            ogrenciler.Remove(43);
            ogrenciler.Remove("burak");

            ogrenciler[147] = "yusuf";
            ogrenciler["rüzgar"] = 145;

            foreach (var anahtar in ogrenciler.Values) 
            {
                Console.WriteLine(anahtar);
            }
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key+"---"+eleman.Value);
            }
            Console.ReadLine();
        }
    }
}
