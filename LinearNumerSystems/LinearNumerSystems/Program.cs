﻿using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] augmentedMatrix = ReadEquations();
            PrintEquations(augmentedMatrix);
            //TODO: extract into method
            //TODO: Name variables better
            int N = 2;
            for (int k=0; k<N; k++)
            {
                for(int i = k+1; i < N; i++)
                {
                    double factor = augmentedMatrix[k, i] / augmentedMatrix[k, k];
                    for (int j=k; j < N+1; j++)
                    {
                        augmentedMatrix[j, i] -= factor * augmentedMatrix[j, k];
                    }
                }
            }
            PrintEquations(augmentedMatrix);
        }

        private static void PrintEquations(double[,] augmentedMatrix)
        {
            //TODO: Implement better printing algorithm
            Console.WriteLine("Your equations:");
            Console.WriteLine($"Eq #1: {augmentedMatrix[0,0]}*x1 + {augmentedMatrix[1, 0]}*x2 = {augmentedMatrix[2, 0]}");
            Console.WriteLine($"Eq #2: {augmentedMatrix[0, 1]}*x1 + {augmentedMatrix[1, 1]}*x2 = {augmentedMatrix[2, 1]}");
        }

        private static double[,] ReadEquations()
        {
            double[,] augmentedMatrix = new double[3, 2];

            for (int eqNo = 0; eqNo < 2; eqNo++)
            {
                Console.WriteLine($"Please type #{eqNo + 1} equation. It should be in the form x1 x2 d.");
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
    }
}
