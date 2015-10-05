using NUnit.Framework;

namespace Calculator.BL.Tests
{
    [TestFixture]
    public class MathematicsTests
    {
        private IMathematics _mathematics;

        [SetUp]
        public void SetUp()
        {
            _mathematics = new Mathematics();    
        }

        [Test]
        public void Add_Test()
        {
            Assert.That(_mathematics.Add(5, 2) == 7);
            Assert.That(_mathematics.Add(5, 10) == 15);
            Assert.That(_mathematics.Add(5, -2) == 3);
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.That(_mathematics.Subtract(5, 2) == 3);
            Assert.That(_mathematics.Subtract(5, 10) == -5);
            Assert.That(_mathematics.Subtract(5, -2) == 7);
        }
    }
}
