using System.Collections.Generic;
using System.Linq;
using Calculator.BL;
using Calculator.Web.Controllers;
using NUnit.Framework;

namespace Calculator.Web.Tests.Controllers
{
    [TestFixture]
    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            int result = controller.Get(new MathematicModel());

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Test]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Test]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
