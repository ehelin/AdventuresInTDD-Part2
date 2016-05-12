using System;
using Shared;
using Shared.interfaces;

namespace Sort
{
    public class SortImpl : ISort
    {
        public string[] SortAscending(string[] values, Enumeration.SupportedDataTypes type)
        {
            string[] result = new string[] { values[0], "Sorted Ascending" };

            return result;
        }

        public string[] SortDescending(string[] values, Enumeration.SupportedDataTypes type)
        {
            string[] result = new string[] { values[0], "Sorted Descending" };

            return result;
        }
    }
}
