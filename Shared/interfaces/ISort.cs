using Shared;

namespace Shared.interfaces
{
    public interface ISort
    {
        //NOTE: While strings are try data types for the inferred type (i.e. decimal, octal, etc), I opted
        //      to use them here to simplify the implementation
        string[] SortAscending(string[] values, Enumeration.SupportedDataTypes type);
        string[] SortDescending(string[] values, Enumeration.SupportedDataTypes type);
    }
}
