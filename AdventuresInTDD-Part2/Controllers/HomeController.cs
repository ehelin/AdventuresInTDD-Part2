using System.Web.Mvc;
using AdventuresInTDD_Part2.Models;

namespace AdventuresInTDD_Part2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ViewResult Conversion()
        {
            ConversionModel model = null;

            return View(model);
        }

        public ViewResult ConversionResult(ConversionModel model)
        {
            ConversionResultModel resultModel = null;

            return View(resultModel);
        }

        public ViewResult Sequence()
        {
            SequenceModel model = null;

            return View(model);
        }

        public ViewResult SequenceResults(SequenceModel model)
        {
            SequenceResultModel resultModel = null;

            return View(resultModel);
        }
    }
}