using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.interfaces;
using Shared;
using Sort;

namespace MSTest_UnitTests
{
    [TestClass]
    public class ISort_Tests
    {
        private ISort sort;

        //NOTE: I know I will need to add additional tests for the different sorts, but since the interface has only two 
        //      methods, I am only adding two to test the basic path :)
        [TestInitialize]
        public void InitializeTests()
        {
            sort = new SortImpl();
        }

        [TestMethod]
        public void MSTest_Test_SortAscending()
        {
            string[] values = new string[] { "" };
            Enumeration.SupportedDataTypes type = Enumeration.SupportedDataTypes.Binary;

            string[] result = sort.SortAscending(values, type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MSTest_Test_SortDescending()
        {
            string[] values = new string[] { "" };
            Enumeration.SupportedDataTypes type = Enumeration.SupportedDataTypes.Binary;

            string[] result = sort.SortDescending(values, type);

            Assert.IsNotNull(result);
        }
    }
}
