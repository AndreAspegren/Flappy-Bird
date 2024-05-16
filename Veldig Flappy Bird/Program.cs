using System;

namespace Hoved
{
    class Program
    {
        internal static void Main(string[] args)
        {
            var obj = new mainClass();
            obj.Run();  
        }
    }

    public class mainClass
    {
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(10);
                Console.Clear();
                Console.WriteLine("   *****   ");
                Console.WriteLine(" *       * ");
                Console.WriteLine("*  O   O  *");
                Console.WriteLine("*    ∆    *");
                Console.WriteLine(" *  \\_/  * ");
                Console.WriteLine("   *****   ");
            }
        }
    }
}

