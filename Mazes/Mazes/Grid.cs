using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    class Grid
    {
        public int Width;
        public int Height;
        public Cell[,] CellsGrid;

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;

            CellsGrid = new Cell[Width, Height];
            //TODO initialize every cell in CellsGrid
        }
    }
}
