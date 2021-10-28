using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    class RecursiveBacktracker
    {
        public static Grid Generate(Grid grid)
        {
            Random rand = new Random();
            Stack<Cell> stack = new Stack<Cell>();
            stack.Push(grid.CellsGrid[0, 0]);
            while (stack.Count > 0)
            {
                Cell current = stack.Peek();
                List<Cell> neighbours = new List<Cell>();
                if (current.North != null && current.North.Links.Count == 0)
                {
                    neighbours.Add(current.North);
                }
                if (current.South != null && current.South.Links.Count == 0)
                {
                    neighbours.Add(current.South);
                }
                if (current.East != null && current.East.Links.Count == 0)
                {
                    neighbours.Add(current.East);
                }
                if (current.West != null && current.West.Links.Count == 0)
                {
                    neighbours.Add(current.West);
                }

                if (neighbours.Count == 0)
                {
                    stack.Pop();
                } else
                {
                    Cell neighbour = neighbours[rand.Next(0, neighbours.Count)];
                    current.LinkCell(neighbour);
                    stack.Push(neighbour);
                }
            }
            return grid;
        }
    }
}
