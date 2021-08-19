using System;

namespace Conversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }


        public static void ConvMethod(string[] userInput)
        {
            int convertedInteger = 0;
            if (userInput.Length > 1)
            {
                int defaultValue = Convert.ToInt32(userInput[1]); // Can throw error to validate user input
                convertedInteger = ConversionUtility.ToSafeInt(userInput[0], defaultValue);
            }
            else
            {
                convertedInteger = ConversionUtility.ToSafeInt(userInput[0]);
            }

            Console.Write("Converted Output is {0}", convertedInteger);
        }
    }
}
