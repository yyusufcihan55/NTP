namespace Metot_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            buyuksayi buyuk = new buyuksayi();
            int a = 100;
            int b = 25;
            int sonuç = buyuk.buyuksayiyibul(a, b);
            Console.WriteLine("büyük olsan sayı"+sonuç);
            Console.ReadLine();
        }
    }
}
