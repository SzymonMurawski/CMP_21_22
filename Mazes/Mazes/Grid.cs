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
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    CellsGrid[x, y].North = y - 1 < 0 ? null : CellsGrid[x, y - 1];
                    CellsGrid[x, y].South = y + 1 >= Height ? null : CellsGrid[x, y + 1];
                    CellsGrid[x, y].West = x - 1 < 0 ? null : CellsGrid[x - 1, y];
                    CellsGrid[x, y].East = x + 1 >= Width ? null : CellsGrid[x + 1, y];
                }
            }
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
