using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type first equation. It should be in the form x1 x2 d.");
            string line1 = Console.ReadLine();
            Console.WriteLine("Please type second equation. It should be in the form x1 x2 d.");
            string line2 = Console.ReadLine();
            Console.WriteLine("Your equations:");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
