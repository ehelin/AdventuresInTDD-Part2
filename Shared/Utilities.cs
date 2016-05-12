using System;

namespace Shared
{
    public class Utilities
    {
        public string[] GetConversionOptions()
        {
            string[] options = GetEnumerationValues(typeof(Enumeration.SupportedDataTypes));

            return options;
        }

        public string[] GetIncrementOptions()
        {
            string[] options = GetEnumerationValues(typeof(Enumeration.SupportedIncrements));

            return options;
        }

        private string[] GetEnumerationValues(Type type)
        {
            Array values = Enum.GetValues(type);  //Source - http://stackoverflow.com/questions/972307/can-you-loop-through-all-enum-values

            string[] options = new string[values.Length];

            for (int ctr = 0; ctr<values.Length; ctr++)
            {
                options[ctr] = values.GetValue(ctr).ToString();
            }

            return options;
        }
    }
}
