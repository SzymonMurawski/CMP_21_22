using System;
using System.Collections.Generic;
using System.Linq;
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
            for(int x = 0; x < Width; x++)
            {
                for(int y = 0; y < Height; y++)
                {
                    CellsGrid[x, y] = new Cell(x, y);
                }
            }
            foreach (Cell cell in EveryCell()) {
                int x = cell.X;
                int y = cell.Y;
                cell.North = GetCellAt(x, y - 1);
                cell.South = GetCellAt(x, y + 1);
                cell.West = GetCellAt(x - 1, y);
                cell.East = GetCellAt(x + 1, y);
            }
        }

        public Cell GetCellAt(int x, int y)
        {
            if(x < 0 || x >= Width || y < 0 || y >= Height)
            {
                return null;
            }
            return CellsGrid[x, y];
        }

        public void Print()
        {
            string output = "+" + string.Concat(Enumerable.Repeat("---+", Height)) + "\n";
            
            for (int y = 0; y < Height; y++)
            {
                string top = "|";
                string bottom = "+";
                for (int x = 0; x < Width; x++)
                {
                    Cell cell = CellsGrid[x, y];
                    string body = "   ";
                    string east_boundary = cell.Linked(cell.East) ? " " : "|";
                    top = top + body + east_boundary;
                    string south_boundary = cell.Linked(cell.South) ? "   " : "---";
                    bottom = bottom + south_boundary + "+";
                }
                output += top + "\n";
                output += bottom + "\n";
            }
            Console.WriteLine(output);
        }

        public IEnumerable<Cell> EveryCell()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    yield return CellsGrid[x, y];
                }
            }
        }
    }
}
