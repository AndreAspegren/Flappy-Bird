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
            var graphics = new Graphics();

            while (state.gameOn)
            {
                Console.Clear();
                Console.WriteLine($"Score: {state.score}");

                foreach (var line in graphics.bird)
                {
                    Console.WriteLine(line.PadLeft((Console.WindowWidth + line.Length) / 2));
                }
                Thread.Sleep(10);
            }
        }
    }

    public class gameState
    {
        public int score = 0;
        public bool gameOn = true;
    }

    public class Graphics
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