using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Calculator.BL;

namespace Calculator.Web.Models
{
    public class Calculator : IUserInterface
    {
        private int _result;

        private readonly IMathematics _mathematics;
        private readonly MathematicModel _model;

        public Calculator(IMathematics mathematics, MathematicModel model)
        {
            _mathematics = mathematics;
            _model = model;
        }

        public MathematicModel ReadModel()
        {
            return _model;
        }

        public void WriteResult(int result)
        {
            _result = result;
        }

        internal int Calculate()
        {
            var calculator = new CalculatorService(_mathematics, this);
            calculator.Run();

            return _result;
        }
    }
}