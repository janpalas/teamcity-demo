using System;
using Calculator.BL.Enums;
using Moq;
using NUnit.Framework;

namespace Calculator.BL.Tests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        private ICalculatorService _calculatorService;

        [SetUp]
        public void SetUp()
        {
            var mathematicsMock = new Mock<IMathematics>();
            mathematicsMock.Setup(m => m.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(100);
            mathematicsMock.Setup(m => m.Subtract(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            _calculatorService = new CalculatorService(mathematicsMock.Object);
        }

        [Test]
        public void Calculate_Test()
        {
            var model = new MathematicModel { First = 5, Second = 2, Operation = Operations.Add };
            Assert.That(_calculatorService.Calculate(model) == 100);

            model.Operation = Operations.Subtract;
            Assert.That(_calculatorService.Calculate(model) == 1);

            model.Operation = (Operations)3;
            Assert.Throws<NotSupportedException>(() => _calculatorService.Calculate(model));
        }
    }
}
