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
        public Dictionary<Cell, bool> Links;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Links = new Dictionary<Cell, bool>();
        }

        public void LinkCell(Cell linkedCell)
        {
            Links[linkedCell] = true;
            linkedCell.Links[this] = true;
        }
        public bool Linked(Cell linkedCell)
        {
            if (linkedCell == null)
            {
                return false;
            }
            if (Links.ContainsKey(linkedCell))
            {
                return Links[linkedCell];
            }
            return false;
        }
    }
}
