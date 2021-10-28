using System;

namespace Mazes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Grid grid = new Grid(10, 10);
            BinaryTreeMaze.Generate(grid);
            grid.Print();
        }
    }
}
