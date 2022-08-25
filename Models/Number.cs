using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersFun.Models
{
    public class Number
    {
        public string EndWord { get; set; }

        public static string ones(string number)
        {
            int num = Convert.ToInt32(number);
            string word = "";
            switch (num)
            {

                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
                case 4:
                    word = "Four";
                    break;
                case 5:
                    word = "Five";
                    break;
                case 6:
                    word = "Six";
                    break;
                case 7:
                    word = "Seven";
                    break;
                case 8:
                    word = "Eight";
                    break;
                case 9:
                    word = "Nine";
                    break;
            }
            return word;
        }

        public static string tens(string number)
        {
            int num = Convert.ToInt32(number);
            string word = "";
            switch (num)
            {
                case 10:
                    word = "Ten";
                    break;
                case 11:
                    word = "Eleven";
                    break;
                case 12:
                    word = "Twelve";
                    break;
                case 13:
                    word = "Thirteen";
                    break;
                case 14:
                    word = "Fourteen";
                    break;
                case 15:
                    word = "Fifteen";
                    break;
                case 16:
                    word = "Sixteen";
                    break;
                case 17:
                    word = "Seventeen";
                    break;
                case 18:
                    word = "Eighteen";
                    break;
                case 19:
                    word = "Nineteen";
                    break;
                case 20:
                    word = "Twenty";
                    break;
                case 30:
                    word = "Thirty";
                    break;
                case 40:
                    word = "Forty";
                    break;
                case 50:
                    word = "Fifty";
                    break;
                case 60:
                    word = "Sixty";
                    break;
                case 70:
                    word = "Seventy";
                    break;
                case 80:
                    word = "Eighty";
                    break;
                case 90:
                    word = "Ninety";
                    break;
                default:
                    if (num > 0)
                    {
                        word = tens(number.Substring(0, 1) + "0") + " " + ones(number.Substring(1));
                    }
                    break;
            }
            return word;
        }

        public static string ConvertWholeNumber(string number)
        {
            string word = "";
            try
            {
                // eg.0120 check begin with zero or not   
                bool startWithZero = false;
                bool isFinished = false;
                double num = (Convert.ToDouble(number));

                if (num > 0)
                {
                    startWithZero = number.StartsWith("0");

                    int numberLength = number.Length;
                    //start position from 0
                    int pos = 0;
                    string place = "";
                    switch (numberLength)
                    {
                        case 1://ones' range    

                            word = ones(number);
                            isFinished = true;
                            break;
                        case 2://tens' range    
                            word = tens(number);
                            isFinished = true;
                            break;
                        case 3:
                            pos = (numberLength % 3) + 1;
                            place = " Hundred ";
                            break;
                        // case 4 -6 : thousands because thousand will be anohter 3 digital block
                        case 4:
                        case 5:
                        case 6:
                            pos = (numberLength % 4) + 1;
                            place = " Thousand ";
                            break;
                        // case 7-9: Millions
                        case 7:
                        case 8:
                        case 9:
                            pos = (numberLength % 7) + 1;
                            place = " Million ";
                            break;
                        // case 10 - 12 billion
                        case 10:
                        case 11:
                        case 12:
                            pos = (numberLength % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isFinished = true;
                            break;
                    }
                    if (!isFinished)
                    {
                        if (number.Substring(0, pos) != "0" && number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(number.Substring(0, pos)) + place + ConvertWholeNumber(number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(number.Substring(0, pos)) + ConvertWholeNumber(number.Substring(pos));
                        }
                    }

                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }

        public static string Decimal(double number)
        {
            string decimals = "";
            string input = Math.Round(number, 2).ToString("0.00");
            string strWords = "";

            if (input.Contains("."))
            {
                decimals = input.Substring(input.IndexOf(".") + 1);
                input = input.Remove(input.IndexOf("."));
                
            }
            if (ConvertWholeNumber(input) == "One")
            {
                strWords = ConvertWholeNumber(input) + " Dollar";
            }
            else
            {
                strWords = ConvertWholeNumber(input) + " Dollars";
            }
            
            
             
           
            // if decimal or cent part in the decimal whole numberequals one (#.01) # can be any number,
            if (decimals.Length > 0 && ConvertWholeNumber(decimals) == "One")
            {
                // strWords returns .... and one cent eg. 3.01 return three dollars and one cent
                strWords += " and " + ConvertWholeNumber(decimals) + " Cent";
            }
            else /*(decimals.Length > 0 && ConvertWholeNumber(decimals) != "One")*/
            {
                // else return cents
                strWords += " and " + ConvertWholeNumber(decimals) + " Cents";
            }
            //input number does contain "." which means it is a whole Number without decimal
            // AND start with "one"
            if (number.ToString().IndexOf(".") == -1 && ConvertWholeNumber(input) == "One")
            {
                // return strWord with singural dollar 
                strWords = ConvertWholeNumber(input) + " Dollar";
            }
            // else the rest situations, strWords return plural dollars
            else if (number.ToString().IndexOf(".") == -1)
            {
                strWords = ConvertWholeNumber(input) + " Dollars";
            }

            // if input decimal number start with 0, such as 0.53 or 0.03
            if (input.StartsWith("0"))
            {
                // strWords only return cents without dollar unit eg. fifty three cents or 3 cents
                strWords = ConvertWholeNumber(decimals) + " Cents";
            }

            //if input decimal number start with 0
            //AND input decimal number equal 0.01 (0.01 will be the ONLY case)
            if (input.StartsWith("0") && number.ToString() == "0.01")
            {
                // strWords return one cent
                strWords = ConvertWholeNumber(decimals) + " Cent";
            }
            
            return strWords;
        }
    }
}


