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
            for (int x = 0; x < grid.Width; x++)
            {
                for (int y = 0; y < grid.Height; y++)
                {

                    List<Cell> neighbours = new List<Cell>();
                    if (grid.CellsGrid[x, y].North != null)
                    {
                        neighbours.Add(grid.CellsGrid[x, y].North);
                    }
                    if (grid.CellsGrid[x, y].East != null)
                    {
                        neighbours.Add(grid.CellsGrid[x, y].East);
                    }

                    if(neighbours.Count > 0)
                    {
                        Cell neighbour = neighbours[rand.Next(0, neighbours.Count)];
                        grid.CellsGrid[x, y].LinkCell(neighbour);
                    }
                }
            }

            return grid;
        }
    }
}
