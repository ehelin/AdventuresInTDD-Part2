using NUnit.Framework;
using Shared.interfaces;
using Conversion;

namespace NUnit_UnitTests
{
    [TestFixture]
    public class IConversion_Tests
    {
        private IConversion conversion;

        [SetUp]
        public void InitializeTests()
        {
            conversion = new ConversionImpl();
        }

        //Binary (i.e. '110010') to X
        [Test]
        public void NUnit_Test_ConvertBinaryToOctal()
        {
            string input = "";

            string result = conversion.ConvertBinaryToOctal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertBinaryToDecimal()
        {
            string input = "";

            string result = conversion.ConvertBinaryToDecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertBinaryToHexadecimal()
        {
            string input = "";

            string result = conversion.ConvertBinaryToHexadecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        //Octal (i.e. '745814') to X
        [Test]
        public void NUnit_Test_ConvertOctalToBinary()
        {
            string input = "";

            string result = conversion.ConvertOctalToBinary(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertOctalToDecimal()
        {
            string input = "";

            string result = conversion.ConvertOctalToDecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertOctalToHexadecimal()
        {
            string input = "";

            string result = conversion.ConvertOctalToHexadecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        //Decimal (i.e. '19') to X
        [Test]
        public void NUnit_Test_ConvertDecimalToBinary()
        {
            string input = "";

            string result = conversion.ConvertDecimalToBinary(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertDecimalToOctal()
        {
            string input = "";

            string result = conversion.ConvertDecimalToOctal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertDecimalToHexadecimal()
        {
            string input = "";

            string result = conversion.ConvertDecimalToHexadecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        //Hexadecimal (i.e. 'AB51') to X
        [Test]
        public void NUnit_Test_ConvertHexadecimalToBinary()
        {
            string input = "";

            string result = conversion.ConvertHexadecimalToBinary(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertHexadecimalToOctal()
        {
            string input = "";

            string result = conversion.ConvertHexadecimalToOctal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [Test]
        public void NUnit_Test_ConvertHexadecimalToDecimal()
        {
            string input = "";

            string result = conversion.ConvertHexadecimalToDecimal(input);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }
    }
}
