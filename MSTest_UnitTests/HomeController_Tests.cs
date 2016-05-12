using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventuresInTDD_Part2.Controllers;
using AdventuresInTDD_Part2.Models;
using System.Web.Mvc;
using Shared;

namespace MSTest_UnitTests
{
    [TestClass]
    public class HomeController_Tests
    {
        private HomeController controller;
        private Utilities utils;

        [TestInitialize]
        public void InitializeTests()
        {
            controller = new HomeController();
            utils = new Utilities();
        }
        
        [TestMethod]
        public void MSTest_Test_Controller_Conversion()
        {
            ViewResult result = controller.Conversion();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_Controller_ConversionResult()
        {
            ConversionModel model = new ConversionModel();
            model.SelectedConversionOptionFrom = Enumeration.SupportedDataTypes.Binary.ToString();
            model.SelectedConversionOptionTo = Enumeration.SupportedDataTypes.Decimal.ToString();
            model.InputValue = "1";

            ViewResult result = controller.ConversionResult(model);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_Controller_Sequence()
        {
            ViewResult result = controller.Sequence();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_Controller_SequenceResult()
        {
            SequenceModel model = new SequenceModel();

            model.SequenceDataTypes = utils.GetConversionOptions();
            model.SelectedSequenceDataType = model.SequenceDataTypes[0];

            model.SequenceIncrementOptions = utils.GetIncrementOptions();
            model.SelectedSequenceIncrement = model.SequenceIncrementOptions[0];

            ViewResult result = controller.SequenceResults(model);

            Assert.IsNotNull(result);
        }
    }
}


