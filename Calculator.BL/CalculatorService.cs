using System;
using Calculator.BL.Enums;

namespace Calculator.BL
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IMathematics _mathematics;
        private readonly IUserInterface _userInterface;

        public CalculatorService(IMathematics mathematics, IUserInterface userInterface)
        {
            _mathematics = mathematics;
            _userInterface = userInterface;
        }

        public void Run()
        {
            MathematicModel model = _userInterface.ReadModel();
            int result = Calculate(model);
            _userInterface.WriteResult(result);
        }

        private int Calculate(MathematicModel model)
        {
            switch (model.Operation)
            {
                case Operations.Add:
                    return _mathematics.Add(model.First, model.Second);
                case Operations.Subtract:
                    return _mathematics.Subtract(model.First, model.Second);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
