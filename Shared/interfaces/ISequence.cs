namespace Shared.interfaces
{
    public interface ISequence
    {
        string[] CreateSequence(string startingValue, Enumeration.SupportedDataTypes type, Enumeration.SupportedIncrements incrementType);
    }
}
