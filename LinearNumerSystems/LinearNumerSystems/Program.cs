using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] augmentedMatrix = new double[3,2];

            Console.WriteLine("Please type first equation. It should be in the form x1 x2 d.");
            string line1 = Console.ReadLine();
            // line1 = "121 25 3123";
            Console.WriteLine("Please type second equation. It should be in the form x1 x2 d.");
            string line2 = Console.ReadLine();

            string[] line1Variables = line1.Split(' ');
            augmentedMatrix[0, 0] = Convert.ToDouble(line1Variables[0]);
            augmentedMatrix[1, 0] = Convert.ToDouble(line1Variables[1]);
            augmentedMatrix[2, 0] = Convert.ToDouble(line1Variables[2]);

            string[] line2Variables = line2.Split(' ');
            augmentedMatrix[0, 1] = Convert.ToDouble(line2Variables[0]);
            augmentedMatrix[1, 1] = Convert.ToDouble(line2Variables[1]);
            augmentedMatrix[2, 1] = Convert.ToDouble(line2Variables[2]);

            Console.WriteLine("Your equations:");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
