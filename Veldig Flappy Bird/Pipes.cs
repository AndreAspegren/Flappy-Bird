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
                initialX = pipes[^1].x + 20;
            }

            pipes.Add(new Pipe(newPipe, initialX, 0, pipePossition));
        }

        public void Draw(int consoleWidth)
        {
            for (int index = 0; index < pipes.Count; index++)
            {
                var pipe = pipes[index];
                if (gameTime == 100) gameTime = 0;
                int pipeX = consoleWidth - gameTime + (index * 20); 
                if (pipeX > 2)
                int pipeX = pipe.x - gameTime;

                
                if (pipeX > 0 && pipeX < consoleWidth)
                {
                    for (int i = 0; i < pipe.pipe.Length; i++)
                    {
                        int pipeY = pipe.isTop == 1 ? 20 - i : 1 + i; 

                        if (pipeY >= 0 && pipeY < 20) 
                        {
                            Console.SetCursorPosition(pipeX, pipeY);
                            Console.WriteLine(pipe.pipe[i]);
                        }
                    }
                }

                
                if (pipeX < 0)
                {
                    pipes.RemoveAt(index);
                    index--;
                    Score++;
                }
            }
        }


        public bool CheckCollision(int birdX, int birdY, int birdHeight)
        {
            foreach (var pipe in pipes)
            {
                if (pipe.x == birdX || pipe.x == birdX + 2)
                {
                    for (int i = 0; i < pipe.pipe.Length; i++)
                    {
                        int pipeY = pipe.isTop == 1 ? 30 - i : 1 + i;
                        if (birdY == pipeY || birdY + birdHeight - 1 == pipeY)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}