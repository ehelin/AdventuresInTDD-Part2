using NUnit.Framework;
using AdventuresInTDD_Part2.Controllers;
using AdventuresInTDD_Part2.Models;
using System.Web.Mvc;

namespace MSTest_UnitTests
{
    [TestFixture]
    public class HomeController_Tests
    {
        private HomeController controller;

        [SetUp]
        public void InitializeTests()
        {
            controller = new HomeController();
        }

        [Test]
        public void NUnit_Test_Conversion()
        {
            ViewResult result = controller.Conversion();

            Assert.IsNotNull(result);
        }

        [Test]
        public void NUnit_Test_ConversionResult()
        {
            ConversionModel model = new ConversionModel();

            ViewResult result = controller.ConversionResult(model);

            Assert.IsNotNull(result);
        }

        [Test]
        public void NUnit_Test_Sequence()
        {
            ViewResult result = controller.Sequence();

            Assert.IsNotNull(result);
        }

        [Test]
        public void NUnit_Test_SequenceResult()
        {
            SequenceModel model = new SequenceModel();

            ViewResult result = controller.SequenceResults(model);

            Assert.IsNotNull(result);
        }
    }
}


