using System;
using System.Threading;

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
            var state = new gameState();
            var graphics = new graphics();
            while (state.gameOn)
            {
                
                Thread.Sleep(1000);

                foreach (var line in graphics.bird)
                {
                    int padding = (Console.WindowWidth - line.Length) / 2;
                    Console.WriteLine(line.PadLeft(padding + line.Length));
                }

                Console.Clear();
            }
        }
    }

    public class gameState
    {
        public int score = 0;
        public bool gameOn = true;
    }

    public class graphics
    {
        public string[] bird = new string[]
        {
            "   *****   ",
            " *       * ",
            "*  O   O  *",
            "*    ∆    *",
            " *  \\_/  * ",
            "   *****   "
        };
    }
}

