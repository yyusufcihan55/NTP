namespace Dikdörtgen_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dıkdortgen d = new dıkdortgen(3,4);
            Console.WriteLine("dikdörtgenin alanı :" + d.alanhesapla());
            Console.WriteLine("dikdörtgenin çevresi :" + d.cevrehesapla());
            Console.ReadLine();
        }
    }
}
