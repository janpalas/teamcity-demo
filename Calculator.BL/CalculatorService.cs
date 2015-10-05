using System;
using Calculator.BL.Enums;

namespace Calculator.BL
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IMathematics _mathematics;

        public CalculatorService(IMathematics mathematics)
        {
            _mathematics = mathematics;
        }

        public int Calculate(MathematicModel model)
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
