﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veldig_Flappy_Bird
{
    internal class Pipe
    {
        public string[] pipe;
        public int x;
        public int y;
        public int isTop;

        public Pipe(string[] p, int X, int Y, int B)
        {
            x = X;
            y = Y;
            pipe = p;
            isTop = B;
        }
    }
}