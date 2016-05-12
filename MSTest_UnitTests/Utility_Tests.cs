using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.interfaces;
using Shared;
using Sequence;

namespace MSTest_UnitTests
{
    [TestClass]
    public class Utility_Tests
    {
        private Utilities utils;

        //NOTE: I know I will need to add additional tests for the different sequences, but since the interface has only one 
        //      method, I am only adding one test to proof the basic path :)
        [TestInitialize]
        public void InitializeTests()
        {
            utils = new Utilities();
        }
        
        [TestMethod]
        public void MSTest_Test_Utility_GetConversionOptions()
        {
            string[] options = utils.GetConversionOptions();

            Assert.IsNotNull(options);
            Assert.AreEqual(options.Length, 4);
        }

        [TestMethod]
        public void MSTest_Test_Utility_GetIncrementOptions()
        {
            string[] options = utils.GetIncrementOptions();

            Assert.IsNotNull(options);
            Assert.AreEqual(options.Length, 4);
        }
    }
}

