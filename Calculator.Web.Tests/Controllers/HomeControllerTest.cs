using System.Web.Mvc;
using Calculator.BL;
using Calculator.Web.Controllers;
using NUnit.Framework;

namespace Calculator.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
            Assert.IsInstanceOf(typeof(MathematicModel), result.Model);
        }

        [Test]
        public void Calculate()
        {
            // Arrange
            HomeController controller = new HomeController();
            var input = new MathematicModel
            {
                First = 5,
                Second = 2
            };

            // Act
            ViewResult result = controller.Calculate(input) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(int), result.Model);
        }
    }
}
