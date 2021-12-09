using System;

namespace LinearNumerSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearSystem linearSystem = new LinearSystem(2);
            for (int eqNo = 0; eqNo < 2; eqNo++)
            {
                Console.WriteLine($"Please type #{eqNo + 1} equation. It should be in the form x1 x2 y.");
                //TODO: Change the display, so it is more like in the task
                string line = Console.ReadLine();
                linearSystem.AddEquation(line, eqNo);
            }
            Console.WriteLine(linearSystem.PrintEquations()); 
            linearSystem.ForwardElimination();
            linearSystem.BacktrackSubstitution();
            Console.WriteLine(linearSystem.PrintResults()); 
        }
    }
}
