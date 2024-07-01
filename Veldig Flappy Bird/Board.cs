using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Board
    {
        public int height = 20;
        public int width = 50;

        public void Draw()
        {
            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
                Console.SetCursorPosition(i, height);
                Console.Write("-");
            }

            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(width, i);
                Console.Write("|");
            }
        }

        public bool CheckCollision(int birdX, int birdY, int birdHeight)
        {
            if (birdX <= 0 || birdX >= width || birdY <= 0 || birdY + birdHeight >= height)
            {
                return true;
            }
            return false;
        }
    }
}