using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.BL;

namespace Calculator.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMathematics mathematics = new Mathematics();
            IUserInterface userInterface = new ConsoleUserInterface();

            var calculator = new CalculatorService(mathematics, userInterface);
            calculator.Run();
        }
    }
}
