using System;
using System.Collections.Generic;

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

            var pipePossition = random.Next(1, 3);

            string[] newPipe = new string[height + 2];
            newPipe[0] = pipePossition == 1 ? "|____|" : "|¨¨¨¨|";
            for (int i = 1; i <= height; i++)
            {
                newPipe[i] = "|    |";
            }
            newPipe[height + 1] = pipePossition == 1 ? "|¨¨¨¨|" : "|____|";

            int initialX = consoleWidth;
            if (pipes.Count > 0)
            {
                initialX = pipes[^1].x + 10;
            }

            pipes.Add(new Pipe(newPipe, initialX, 50, pipePossition));
        }

        public void draw(int consoleWidth)
        {
            Console.Clear();
            for (int index = 0; index < pipes.Count; index++)
            {
                var pipe = pipes[index];
                int pipeX = consoleWidth - gameTime + (index * 20); 
                if (gameTime == 100) gameTime = 0;
                if (pipeX > 2)
                {
                    for (int i = 0; i < pipe.pipe.Length; i++)
                    {
                        Console.SetCursorPosition(pipeX < 210 ? pipeX : 210, pipe.isTop == 1 ? 30 - i : 0 + i);
                        Console.WriteLine(pipe.pipe[i]);
                    }
                }
                else pipes.RemoveAt(index);
            }
        }
    }
}