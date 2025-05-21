namespace InterFaceeUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] workers = new IWork[3];
            {
                new Workerr();
                new Managerr();
                new Robott();
            };
            foreach (var worker in workers) 
            {
                worker.work();
            }
            Console.WriteLine("-------");

            IEat[] eats = new IEat[2];
            {
                new Workerr();
                new Managerr();
            }
            foreach (var eat in eats) 
            {
                eat.Eat();
            }
            Console.ReadLine();
        }
    }
}
