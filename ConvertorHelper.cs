using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersFun
{
    public class ConvertorHelper
    {
        public String Ones(String numberToConvert)
        {
            double num = Convert.ToInt32(numberToConvert);
            String word = null;

            switch (num)
            {
                case 1:
                    word = "ONE";
                    break;
                case 2:
                    word = "TWO";
                    break;
                case 3:
                    word = "THREE";
                    break;
                case 4:
                    word = "FOUR";
                    break;
                case 5:
                    word = "FIVE";
                    break;
                case 6:
                    word = "SIX";
                    break;
                case 7:
                    word = "SEVEN";
                    break;
                case 8:
                    word = "EIGHT";
                    break;
                case 9:
                    word = "NINE";
                    break;
            }

            return word;
        }

    }
}
