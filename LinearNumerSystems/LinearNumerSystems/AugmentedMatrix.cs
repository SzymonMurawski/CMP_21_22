using System;
using System.Collections.Generic;
using System.Text;

namespace LinearNumerSystems
{
    public class AugmentedMatrix
    {
        public int NumberOfEquations { get; set; }
        public double[,] Matrix { get; set; }
        public AugmentedMatrix(int numberOfEquations)
        {
            NumberOfEquations = numberOfEquations;
            Matrix = new double[numberOfEquations + 1, numberOfEquations];
        }

        public void ForwardElimination()
        {
            for (int diagonalVariableIndex = 0; diagonalVariableIndex < NumberOfEquations; diagonalVariableIndex++)
            {
                for (int currentEquationIndex = diagonalVariableIndex + 1; currentEquationIndex < NumberOfEquations; currentEquationIndex++)
                {
                    double factor = Matrix[diagonalVariableIndex, currentEquationIndex] / Matrix[diagonalVariableIndex, diagonalVariableIndex];
                    // NumberOfEquations+1, because we are also changing the result
                    for (int currentVariableIndex = diagonalVariableIndex; currentVariableIndex < NumberOfEquations + 1; currentVariableIndex++)
                    {
                        Matrix[currentVariableIndex, currentEquationIndex] -= factor * Matrix[currentVariableIndex, diagonalVariableIndex];
                    }
                }
            }
        }
        public double[] BacktrackSubstitution()
        {
            //TODO: Implement this function. It should perform the backtrack substitution on the augmented matrix and return the total result - variables and their values
            throw new NotImplementedException();
        }
        public string GetEquations()
        {
            string output = "Your equations:\n";
            output += $"Eq #1: {Matrix[0, 0]}*x1 + {Matrix[1, 0]}*x2 = {Matrix[2, 0]}\n";
            output += $"Eq #2: {Matrix[0, 1]}*x1 + {Matrix[1, 1]}*x2 = {Matrix[2, 1]}\n";
            return output;
        }
        public string GetResults()
        {
            // TODO implement this function. It should print to the user the results in a nice looking way, for example something like:
            // x1 = 123
            // x2 = 456
            throw new NotImplementedException();
        }
    }
}
