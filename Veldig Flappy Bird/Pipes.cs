using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Pipes
    {
        private static Random random = new Random();
        public List<Pipe> pipes = new();
        public int gameTime = 0;
        public int Score { get; private set; } = 0;

        public void addPipe(int consoleWidth)
        {
            var height = random.Next(5, 15);
            string[] newPipe = new string[height + 2];
            newPipe[0] = "|¨¨¨¨|";
            for (int i = 1; i <= height; i++)
            {
                newPipe[i] = "|    |";
            }
            newPipe[height + 1] = "|____|";
            pipes.Add(new Pipe(newPipe, consoleWidth, 70));
        }

        public void draw(int x, int y)
        {
            Console.Clear();
            foreach (var pipe in pipes)
            {
                for (int i = 0; i < pipe.pipe.Length; i++)
                {
                    Console.SetCursorPosition(x + gameTime, y + i);
                    Console.WriteLine(pipe.pipe[i]);
                }
            }
        }
    }
}

