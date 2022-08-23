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
                double num = Convert.ToInt32(numberToConvert);
                string word = null;

                return word;
            }


            ViewBag.number = num;
            ViewBag.word = Ones(numberToConvert);
            return View("Convert", word);
        }
    }
}

 