using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    public static class ConversionUtility
    {

        //Part 1
        public static int ToSafeInt(string input)
        {
            bool isSuccess = Int32.TryParse(input, out int result);

            //Since no clarity on deafult value to use using the int default
            return (isSuccess) ? result : default;
        }
        
        //Part 2
        public static int ToSafeInt(string input, int defaultValue)
        {
            int result = ToSafeInt(input, out bool isSuccess);

            return (isSuccess) ? result : defaultValue;
        }

        //Main worker method // Other 2 methods are reusing this
        private static int ToSafeInt(string input, out bool isSuccess)
        {
            isSuccess = Int32.TryParse(input, out int result);

            //Since no clarity on deafult value to use using the int default
            return result;
        }
    }
}
