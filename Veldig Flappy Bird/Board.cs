using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Board
    {
        public int height = 54;
        public int width = 127;
        public void draw()
        {
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
                Console.SetCursorPosition(i, height);
                Console.Write("-");
            }
        }
    }
}
