using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    class Cell
    {
        public int X;
        public int Y;
        public Cell North;
        public Cell South;
        public Cell East;
        public Cell West;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
