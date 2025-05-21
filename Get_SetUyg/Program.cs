namespace Get_SetUyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            araba araba1 = new araba();
            araba1.Setrenk("Mavi");
            Console.WriteLine("arabanın rengi"+araba1.getrenk());

            araba araba2 = new araba();
            araba2.Setrenk("yeşil");
            Console.WriteLine("arabanın rengi" + araba2.getrenk());

            Console.ReadLine();
        }
    }
}
