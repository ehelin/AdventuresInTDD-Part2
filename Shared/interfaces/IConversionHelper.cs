namespace Shared.interfaces
{
    public interface IConversionHelper
    {
        string ConvertValue(Enumeration.SupportedDataTypes From, Enumeration.SupportedDataTypes To, string inputValue);
    }
}
