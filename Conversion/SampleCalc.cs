using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    public  class SampleCalc
    {
            public int SampleCalculator(CalcInput input)
            {
                int output = 0;
                if (input == null)
                    throw new ArgumentNullException("input is null");
                try
                {
                    switch (input.operation)
                    {
                        case Operation.Sum:
                            output = input.Num1 + input.Num2;
                            break;
                        case Operation.Multiply:
                            output = input.Num1 * input.Num2;
                            break;
                        case Operation.Divide:
                            output = input.Num1 / input.Num2;
                            break;
                        default:
                            break;
                    }

                    return output;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
