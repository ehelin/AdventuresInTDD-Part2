using Conversion;
using Shared;
using Shared.interfaces;

namespace AdventuresInTDD_Part2.Helper
{
    public class ConversionHelper : IConversionHelper
    {
        private IConversion conversion;

        public ConversionHelper()
        {
            conversion = new ConversionImpl();
        }

        public string ConvertValue(Enumeration.SupportedDataTypes From, Enumeration.SupportedDataTypes To, string inputValue)
        {
            string convertedValue = string.Empty;

            //binary
            if (From == Enumeration.SupportedDataTypes.Binary && To == Enumeration.SupportedDataTypes.Decimal)
                convertedValue = conversion.ConvertBinaryToDecimal(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Binary && To == Enumeration.SupportedDataTypes.Octal)
                convertedValue = conversion.ConvertBinaryToOctal(inputValue);            
            else if (From == Enumeration.SupportedDataTypes.Binary && To == Enumeration.SupportedDataTypes.Hexidecimal)
                convertedValue = conversion.ConvertBinaryToHexadecimal(inputValue);

            //octal
            else if (From == Enumeration.SupportedDataTypes.Octal && To == Enumeration.SupportedDataTypes.Binary)
                convertedValue = conversion.ConvertOctalToBinary(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Octal && To == Enumeration.SupportedDataTypes.Decimal)
                convertedValue = conversion.ConvertOctalToDecimal(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Octal && To == Enumeration.SupportedDataTypes.Hexidecimal)
                convertedValue = conversion.ConvertOctalToHexadecimal(inputValue);

            //decimal
            else if (From == Enumeration.SupportedDataTypes.Decimal && To == Enumeration.SupportedDataTypes.Binary)
                convertedValue = conversion.ConvertDecimalToBinary(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Decimal && To == Enumeration.SupportedDataTypes.Octal)
                convertedValue = conversion.ConvertDecimalToOctal(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Decimal && To == Enumeration.SupportedDataTypes.Hexidecimal)
                convertedValue = conversion.ConvertDecimalToHexadecimal(inputValue);

            //hexidecimal
            else if (From == Enumeration.SupportedDataTypes.Hexidecimal && To == Enumeration.SupportedDataTypes.Binary)
                convertedValue = conversion.ConvertHexadecimalToBinary(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Hexidecimal && To == Enumeration.SupportedDataTypes.Octal)
                convertedValue = conversion.ConvertHexadecimalToOctal(inputValue);
            else if (From == Enumeration.SupportedDataTypes.Hexidecimal && To == Enumeration.SupportedDataTypes.Decimal)
                convertedValue = conversion.ConvertHexadecimalToDecimal(inputValue);

            else
                throw new System.Exception("Unknown conversion");

            return convertedValue;
        }
    }
}