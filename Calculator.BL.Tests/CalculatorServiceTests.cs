using System;
using Calculator.BL.Enums;
using Moq;
using NUnit.Framework;

namespace Calculator.BL.Tests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        [Test]
        public void Run_Test()
        {
            var mathematicsMock = new Mock<IMathematics>();
            mathematicsMock.Setup(m => m.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(100);
            mathematicsMock.Setup(m => m.Subtract(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var userInterfaceMock = new Mock<IUserInterface>();
            userInterfaceMock.Setup(c => c.ReadModel()).Returns(new MathematicModel { First = 5, Second = 2 });
            userInterfaceMock.Setup(c => c.WriteResult(100)).Verifiable("Output of add operation should be written to the ui");

            var calculatorService = new CalculatorService(mathematicsMock.Object, userInterfaceMock.Object);

            calculatorService.Run();

            userInterfaceMock.VerifyAll();
        }

        [Test]
        public void Run_NotSupportedOperation_Test()
        {
            var userInterfaceMock = new Mock<IUserInterface>();
            userInterfaceMock.Setup(c => c.ReadModel()).Returns(new MathematicModel { First = 5, Second = 2, Operation = (Operations)3});

            var calculatorService = new CalculatorService(new Mock<IMathematics>().Object, userInterfaceMock.Object);

            Assert.Throws<NotSupportedException>(() => calculatorService.Run());
        }
    }
}
