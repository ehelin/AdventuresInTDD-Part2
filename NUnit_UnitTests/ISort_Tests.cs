using NUnit.Framework;
using Shared.interfaces;
using Shared;
using Sort;

namespace NUnit_UnitTests
{
    [TestFixture]
    public class ISort_Tests
    {
        private ISort sort;

        //NOTE: I know I will need to add additional tests for the different sorts, but since the interface has only two 
        //      methods, I am only adding two to test the basic path :)
        [SetUp]
        public void InitializeTests()
        {
            sort = new SortImpl();
        }

        [Test]
        public void NUnit_Test_SortAscending()
        {
            string[] values = new string[] { "" };
            Enumeration.SupportedDataTypes type = Enumeration.SupportedDataTypes.Binary;

            string[] result = sort.SortAscending(values, type);

            Assert.IsNotNull(result);
        }

        [Test]
        public void NUnit_Test_SortDescending()
        {
            string[] values = new string[] { "" };
            Enumeration.SupportedDataTypes type = Enumeration.SupportedDataTypes.Binary;

            string[] result = sort.SortDescending(values, type);

            Assert.IsNotNull(result);
        }
    }
}
