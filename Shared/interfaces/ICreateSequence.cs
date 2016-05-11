namespace Shared.interfaces
{
    public interface ICreateSequence
    {
        string[] CreateSequence(string startingValue, Enumeration.SupportedDataTypes type);
    }
}
