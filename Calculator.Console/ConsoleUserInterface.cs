using System;
using Calculator.BL;
using Calculator.BL.Enums;

namespace Calculator.Console
{
    internal class ConsoleUserInterface : IUserInterface
    {
        public MathematicModel ReadModel()
        {
            int first = ReadNumber("Insert first number:");
            int second = ReadNumber("Insert second number:");
            Operations operation = ReadOperation();

            return new MathematicModel
            {
                First = first,
                Second = second,
                Operation = operation
            };
        }

        private static int ReadNumber(string message)
        {
            System.Console.WriteLine(message);
            return Convert.ToInt32(System.Console.ReadLine());
        }

        private static Operations ReadOperation()
        {
            System.Console.WriteLine("Insert operation name");
            Operations operation;
            Enum.TryParse(System.Console.ReadLine(), out operation);
            return operation;
        }

        public void WriteResult(int result)
        {
            string message = string.Format("Result is: {0}", result);
            System.Console.WriteLine(message);
            System.Console.WriteLine("Press any key to exit...");
            //Console.ReadKey(); // causes issues in the acceptance test, ignore for now
        }
    }
}
