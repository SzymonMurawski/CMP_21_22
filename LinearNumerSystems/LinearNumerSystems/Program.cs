using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] augmentedMatrix = ReadEquations();
            PrintEquations(augmentedMatrix);
        }

        private static void PrintEquations(double[,] augmentedMatrix)
        {
            Console.WriteLine("Your equations:");
            Console.WriteLine(augmentedMatrix);
        }

        private static double[,] ReadEquations()
        {
            double[,] augmentedMatrix = new double[3, 2];

            for (int eqNo = 0; eqNo < 2; eqNo++)
            {
                Console.WriteLine($"Please type #{eqNo + 1} equation. It should be in the form x1 x2 d.");
                string line = Console.ReadLine();
                string[] lineVariables = line.Split(' ');
                augmentedMatrix[0, eqNo] = Convert.ToDouble(lineVariables[0]);
                augmentedMatrix[1, eqNo] = Convert.ToDouble(lineVariables[1]);
                augmentedMatrix[2, eqNo] = Convert.ToDouble(lineVariables[2]);
            }

            return augmentedMatrix;
        }
    }
}
