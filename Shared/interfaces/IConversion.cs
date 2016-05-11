namespace Shared.interfaces
{
    public interface IConversion
    {
        //NOTE: While strings are try data types for the inferred type (i.e. decimal, octal, etc), I opted
        //      to use them here to simplify the implementation
        //Binary (i.e. '100101') to X 
        string ConvertBinaryToOctal(string binaryValue);
        string ConvertBinaryToDecimal(string binaryValue);
        string ConvertBinaryToHexadecimal(string binaryValue);

        //Octal (i.e. '745814') to X
        string ConvertOctalToBinary(string octalValue);
        string ConvertOctalToDecimal(string octalValue);
        string ConvertOctalToHexadecimal(string octalValue);

        //Decimal (i.e. '19') to X
        string ConvertDecimalToBinary(string decimalValue);
        string ConvertDecimalToOctal(string decimalValue);
        string ConvertDecimalToHexadecimal(string decimalValue);

        //Hexadecimal (i.e. 'AB51') to X
        string ConvertHexadecimalToBinary(string hexadecimalValue);
        string ConvertHexadecimalToOctal(string hexadecimalValue);
        string ConvertHexadecimalToDecimal(string hexadecimalValue);
    }
}
