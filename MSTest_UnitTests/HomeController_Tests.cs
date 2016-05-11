using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventuresInTDD_Part2.Controllers;
using AdventuresInTDD_Part2.Models;
using System.Web.Mvc;

namespace MSTest_UnitTests
{
    [TestClass]
    public class HomeController_Tests
    {
        private HomeController controller;

        [TestInitialize]
        public void InitializeTests()
        {
            controller = new HomeController();
        }
        
        [TestMethod]
        public void MSTest_Test_Conversion()
        {
            ViewResult result = controller.Conversion();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_ConversionResult()
        {
            ConversionModel model = new ConversionModel();

            ViewResult result = controller.ConversionResult(model);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_Sequence()
        {
            ViewResult result = controller.Sequence();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_SequenceResult()
        {
            SequenceModel model = new SequenceModel();

            ViewResult result = controller.SequenceResults(model);

            Assert.IsNotNull(result);
        }
    }
}


