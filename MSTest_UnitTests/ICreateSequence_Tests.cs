using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.interfaces;
using Shared;
using Sequence;

namespace MSTest_UnitTests
{
    [TestClass]
    public class ICreateSequence_Tests
    {
        private ICreateSequence createSequence;

        //NOTE: I know I will need to add additional tests for the different sequences, but since the interface has only one 
        //      method, I am only adding one test to proof the basic path :)
        [TestInitialize]
        public void InitializeTests()
        {
            createSequence = new SequenceImpl();
        }

        [TestMethod]
        public void MSTest_Test_CreateSequence()
        {
            string input = "";
            Enumeration.SupportedDataTypes type = Enumeration.SupportedDataTypes.Binary;

            string[] result = createSequence.CreateSequence(input, type);

            Assert.IsNotNull(result);
        }
    }
}

