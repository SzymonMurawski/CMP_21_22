using System;
using System.Collections.Generic;
using System.Text;

namespace LinearNumerSystems
{
    class LinearSystem
    {
        public int NumberOfEquations { get; set; }
        public double[,] AugmentedMatrix { get; set; }
        public LinearSystem(int numberOfEquations)
        {
            NumberOfEquations = numberOfEquations;
            AugmentedMatrix = new double[numberOfEquations + 1, numberOfEquations];
        }
        public LinearSystem(double[,] augmentedMatrix)
        {
            AugmentedMatrix = augmentedMatrix;
            NumberOfEquations = AugmentedMatrix.GetLength(1);
        }
        public void AddEquation(string equation, int equationIndex)
        {
            string[] equationVariables = equation.Split(' ');
            AugmentedMatrix[0, equationIndex] = Convert.ToDouble(equationVariables[0]);
            AugmentedMatrix[1, equationIndex] = Convert.ToDouble(equationVariables[1]);
            AugmentedMatrix[2, equationIndex] = Convert.ToDouble(equationVariables[2]);
        }
        public string PrintEquations()
        {
            string output = "Your equations:\n";
            output += $"Eq #1: {AugmentedMatrix[0, 0]}*x1 + {AugmentedMatrix[1, 0]}*x2 = {AugmentedMatrix[2, 0]}\n";
            output += $"Eq #2: {AugmentedMatrix[0, 1]}*x1 + {AugmentedMatrix[1, 1]}*x2 = {AugmentedMatrix[2, 1]}\n";
            return output;
        }
        public void ForwardElimination()
        {
            for (int diagonalVariableIndex = 0; diagonalVariableIndex < NumberOfEquations; diagonalVariableIndex++)
            {
                for (int currentEquationIndex = diagonalVariableIndex + 1; currentEquationIndex < NumberOfEquations; currentEquationIndex++)
                {
                    double factor = AugmentedMatrix[diagonalVariableIndex, currentEquationIndex] / AugmentedMatrix[diagonalVariableIndex, diagonalVariableIndex];
                    // NumberOfEquations+1, because we are also changing the result
                    for (int currentVariableIndex = diagonalVariableIndex; currentVariableIndex < NumberOfEquations + 1; currentVariableIndex++)
                    {
                        AugmentedMatrix[currentVariableIndex, currentEquationIndex] -= factor * AugmentedMatrix[currentVariableIndex, diagonalVariableIndex];
                    }
                }
            }
        }
        private double[] BacktrackSubstitution()
        {
            //TODO: Implement this function. It should perform the backtrack substitution on the augmented matrix and return the total result - variables and their values
            throw new NotImplementedException();
        }

        private string PrintResults()
        {
            // TODO implement this function. It should print to the user the results in a nice looking way, for example something like:
            // x1 = 123
            // x2 = 456
            throw new NotImplementedException();
        }
    }
}
