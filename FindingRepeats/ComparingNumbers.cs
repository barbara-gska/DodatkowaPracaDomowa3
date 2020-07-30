using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRepeats
{
    public static class ComparingNumbers
    {
        public static bool CompareNumbers(string number1, string number2)
        {
            char repeatedNumber = ' ';
            
            for (int i = 0; i < (number1.Length - 2); i++)
            {
                if (number1[i].Equals(number1[i +1]) && number1[i].Equals(number1[i + 2]))
                {
                    repeatedNumber = number1[i];
                    break;
                }
            }

            for (int i = 0; i < (number2.Length - 1); i++)
            {
                if (number2[i].Equals(number2[i + 1]) && number2[i] == repeatedNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
