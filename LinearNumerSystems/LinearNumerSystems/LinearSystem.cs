using System;
using System.Collections.Generic;
using System.Text;

namespace LinearNumerSystems
{
    public class LinearSystem
    {
        public int NumberOfEquations { get; set; }
        public List<string> Equations { get; set; }
        public LinearSystem(int numberOfEquations)
        {
            Equations = new List<string>();
        }
        public LinearSystem()
        {
        }
        public void AddEquation(string equation)
        {
            Equations.Add(equation);
            NumberOfEquations++;
        }
        public string PrintEquations()
        {
            //TODO change it so that it doesnt use the Matrix class
            throw new NotImplementedException();
        }
        public string GetResults()
        {
            AugmentedMatrix Matrix = new AugmentedMatrix(Equations.Count);
            for(int eqNo = 0; eqNo < Equations.Count; eqNo++)
            {
                string[] equationVariables = Equations[eqNo].Split(' ');
                for(int variableNo = 0; variableNo < Equations.Count + 1; variableNo++)
                {
                    Matrix.Matrix[variableNo, eqNo] = Convert.ToDouble(equationVariables[variableNo]);
                }
            }
            
            Matrix.ForwardElimination();
            Matrix.BacktrackSubstitution();
            return Matrix.GetResults();
        }
    }
}
