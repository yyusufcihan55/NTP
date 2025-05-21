namespace Hayvanlarrİnterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedı kedi = new Kedı();
            kedi = beslen();
            kedi = sescikar();
            Console.WriteLine("          ");
            Kopek köpek = new Kopek();
            köpek = beslen();
            köpek = sescikar();
            Console.ReadLine();
        }
    }
}
