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
                Console.Clear();
                Thread.Sleep(1);
                Console.WriteLine(state.score);
                
                Console.WriteLine($"{graphics.bird}");

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

