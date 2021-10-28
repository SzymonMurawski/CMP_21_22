using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    class BinaryTreeMaze
    {
        public static Grid Generate(Grid grid)
        {
            Random rand = new Random();
            foreach(Cell cell in grid.EveryCell())
            {
                List<Cell> neighbours = new List<Cell>();
                if (cell.North != null)
                {
                    neighbours.Add(cell.North);
                }
                if (cell.East != null)
                {
                    neighbours.Add(cell.East);
                }

                if (neighbours.Count > 0)
                {
                    Cell neighbour = neighbours[rand.Next(0, neighbours.Count)];
                    cell.LinkCell(neighbour);
                }
            }

            return grid;
        }
    }
}
