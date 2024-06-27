using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Bird
    {
        private int X { get; set; }
        private int Y { get; set; }
        public string[] bird = new string[]
        {
       "(V)",
 "(^    (`>",
"((\\__/ )",
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
                Console.SetCursorPosition(X, Y);
                Console.Write(bird[i]);
            }

        }
        public void Jump()
        {
            if (Y > 0)
            {
                Y--;
            }

        }
        public void Down()
        {
            if (Y < Console.WindowHeight - bird.Length)
            {
                Y++;
            }

        }
    }
}
