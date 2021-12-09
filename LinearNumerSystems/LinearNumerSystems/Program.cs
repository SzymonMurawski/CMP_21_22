using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] augmentedMatrix = ReadEquations();
            PrintEquations(augmentedMatrix);
            ForwardElimination(augmentedMatrix);
            double[] results = BacktrackSubstitution(augmentedMatrix);
            PrintResults(results);
        }
        private static double[,] ReadEquations()
        {
            double[,] augmentedMatrix = new double[3, 2];

            for (int eqNo = 0; eqNo < 2; eqNo++)
            {
                Console.WriteLine($"Please type #{eqNo + 1} equation. It should be in the form x1 x2 y.");
                //TODO: Change the display, so it is more like in the task
                string line = Console.ReadLine();
                string[] lineVariables = line.Split(' ');
                //TODO: Refactor and change into loop
                augmentedMatrix[0, eqNo] = Convert.ToDouble(lineVariables[0]);
                augmentedMatrix[1, eqNo] = Convert.ToDouble(lineVariables[1]);
                augmentedMatrix[2, eqNo] = Convert.ToDouble(lineVariables[2]);
            }
            return augmentedMatrix;
        }
        private static void PrintEquations(double[,] augmentedMatrix)
        {
            //TODO: Implement better printing algorithm
            Console.WriteLine("Your equations:");
            Console.WriteLine($"Eq #1: {augmentedMatrix[0, 0]}*x1 + {augmentedMatrix[1, 0]}*x2 = {augmentedMatrix[2, 0]}");
            Console.WriteLine($"Eq #2: {augmentedMatrix[0, 1]}*x1 + {augmentedMatrix[1, 1]}*x2 = {augmentedMatrix[2, 1]}");
        }
        private static void ForwardElimination(double[,] augmentedMatrix)
        {
            //TODO: extract into method
            int NumberOfEquations = 2;
            for (int diagonalVariableIndex = 0; diagonalVariableIndex < NumberOfEquations; diagonalVariableIndex++)
            {
                for (int currentEquationIndex = diagonalVariableIndex + 1; currentEquationIndex < NumberOfEquations; currentEquationIndex++)
                {
                    double factor = augmentedMatrix[diagonalVariableIndex, currentEquationIndex] / augmentedMatrix[diagonalVariableIndex, diagonalVariableIndex];
                    // NumberOfEquations+1, because we are also changing the result
                    for (int currentVariableIndex = diagonalVariableIndex; currentVariableIndex < NumberOfEquations + 1; currentVariableIndex++)
                    {
                        augmentedMatrix[currentVariableIndex, currentEquationIndex] -= factor * augmentedMatrix[currentVariableIndex, diagonalVariableIndex];
                    }
                }
            }
        }
        private static double[] BacktrackSubstitution(double[,] augmentedMatrix)
        {
            //TODO: Implement this function. It should perform the backtrack substitution on the augmented matrix and return the total result - variables and their values
            throw new NotImplementedException();
        }

        private static void PrintResults(double[] results)
        {
            // TODO implement this function. It should print to the user the results in a nice looking way, for example something like:
            // x1 = 123
            // x2 = 456
            throw new NotImplementedException();
        }
    }
}
