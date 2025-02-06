namespace Buyuk_Sayı_Class
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            buyuksayi buyuk = new buyuksayi();
            int a = 100;
            int b = 250;
            int sonuc = buyuk.büyüksayiyibul(a, b);
            Console.WriteLine("büyük olan sayı"+sonuc);
            Console.ReadLine();
        }
    }
}
