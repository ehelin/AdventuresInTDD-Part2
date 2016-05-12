using NUnit.Framework;
using Shared.interfaces;
using Shared;
using Sort;

namespace NUnit_UnitTests
{
    [TestFixture]
    public class Utility_Tests
    {
        private Utilities utils;

        //NOTE: I know I will need to add additional tests for the different sequences, but since the interface has only one 
        //      method, I am only adding one test to proof the basic path :)
        [SetUp]
        public void InitializeTests()
        {
            utils = new Utilities();
        }
        
        [Test]
        public void NUnit_Test_GetConversionOptions()
        {
            string[] options = utils.GetConversionOptions();

            Assert.IsNotNull(options);
            Assert.AreEqual(options.Length, 4);
        }

        [Test]
        public void NUnit_Test_GetIncrementOptions()
        {
            string[] options = utils.GetIncrementOptions();

            Assert.IsNotNull(options);
            Assert.AreEqual(options.Length, 4);
        }
    }
}

