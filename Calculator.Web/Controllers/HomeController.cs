using System.Web.Mvc;
using Calculator.BL;

namespace Calculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMathematics _mathematics;

        public HomeController()
        {
            _mathematics = new Mathematics();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View(new MathematicModel());
        }

        public ActionResult Calculate(MathematicModel input)
        {
            var ui = new Models.Calculator(_mathematics, input);
            return View(ui.Calculate());
        }
    }
}
