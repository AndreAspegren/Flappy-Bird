using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Bird
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string[] bird = new string[]
        {
       "(V)",
 "(^    (`>",
@"((\__/ )",
 @"\<   )",
  @"\<  )",
   "( /",
   "|",
   " ^",


        };
        public Bird(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        public void Draw()
        {
            for (int i = 0; i < bird.Length; i++)
            {
                Console.SetCursorPosition(X, Y+i);
                Console.Write(bird[i]);
            }

        }
        public void Jump()
        {
            if (Y > 1)
            {
                Y-= 3;
            }

        }
        public void Down()
        {
            if (Y < Console.WindowHeight - bird.Length -2)
            {
                Y++;
            }

        }
    }
}
