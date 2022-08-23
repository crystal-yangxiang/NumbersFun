using Microsoft.AspNetCore.Mvc;
using NumbersFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NumbersFun.Controllers
{
    public class ConvertController : Controller
    {

        //private readonly ConvertorHelper convertorHelper;

        [HttpGet]
        public IActionResult ConvertNumbers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConvertNumbers(string numberToConvert)
        {
            double num = Convert.ToInt32(numberToConvert);
            string word = null;
            //var number = convertorHelper.Ones(numberToConvert);
            String Ones(String numberToConvert)
            {

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

            String Tens(String numberToConvert)
            {             

                switch (num)
                {
                    case 10:
                        word = "TEN";
                        break;
                    case 11:
                        word = "ELEVEN";
                        break;
                    case 12:
                        word = "TWELVE";
                        break;
                    case 13:
                        word = "THIRTEEN";
                        break;
                    case 14:
                        word = "FOURTEEN";
                        break;
                    case 15:
                        word = "FIFTEEN";
                        break;
                    case 16:
                        word = "SIXTEEN";
                        break;
                    case 17:
                        word = "SEVENTEEN";
                        break;
                    case 18:
                        word = "EIGHTEEN";
                        break;
                    case 19:
                        word = "NINETEEN";
                        break;
                    case 20:
                        word = "TWENTY";
                        break;
                    case 30:
                        word = "THIRTY";
                        break;
                    case 40:
                        word = "FOURTY";
                        break;
                    case 50:
                        word = "FIFTY";
                        break;
                    case 60:
                        word = "SIXTY";
                        break;
                    case 70:
                        word = "SEVENTY";
                        break;
                    case 80:
                        word = "EIGHTY";
                        break;
                    case 90:
                        word = "NINETY";
                        break;
                    default:


                        word = Tens(numberToConvert.Substring(0, 1) + "0") + Ones(numberToConvert.Substring(1, 1));

                        break;

                }
                return word;
            }


            ViewBag.number = num;
            ViewBag.word = Ones(numberToConvert);
            ViewBag.word = Tens(numberToConvert);
            return View("Convert", word);
        }
    }
}

 