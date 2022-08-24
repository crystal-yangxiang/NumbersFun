﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersFun
{
    public class ConvertorHelper
    {

        //public static string NumberToWord(decimal number, MidpointRounding midpointRounding)
        //{
        //    number = decimal.Round(number, 2, midpointRounding);

        //    string[] arrNumber = number.ToString().Split('.');

        //    long wholePart = long.Parse(arrNumber[0]);

        //    string[] numbersUptoHundred = new string[] { "शुन्य", "एक", "दुई", "तीन", "चार", "पाँच", "छ", "सात", "आठ", "नौ", "दश", "एघार", "बाह्र", "तेह्र", "चौध", "पन्ध्र", "सोह्र", "सत्र", "अठार", "उन्नाइस", "विस", "एक्काइस", "बाइस", "तेईस", "चौविस", "पच्चिस", "छब्बिस", "सत्ताइस", "अठ्ठाईस", "उनन्तिस", "तिस", "एकत्तिस", "बत्तिस", "तेत्तिस", "चौँतिस", "पैँतिस", "छत्तिस", "सैँतीस", "अठतीस", "उनन्चालीस", "चालीस", "एकचालीस", "बयालीस", "त्रियालीस", "चवालीस", "पैँतालीस", "छयालीस", "सच्चालीस", "अठचालीस", "उनन्चास", "पचास", "एकाउन्न", "बाउन्न", "त्रिपन्न", "चउन्न", "पचपन्न", "छपन्न", "सन्ताउन्न", "अन्ठाउन्न", "उनन्साठी", "साठी", "एकसट्ठी", "बयसट्ठी", "त्रिसट्ठी", "चौंसट्ठी", "पैंसट्ठी", "छयसट्ठी", "सतसट्ठी", "अठसट्ठी", "उनन्सत्तरी", "सत्तरी", "एकहत्तर", "बहत्तर", "त्रिहत्तर", "चौहत्तर", "पचहत्तर", "छयहत्तर", "सतहत्तर", "अठहत्तर", "उनासी", "असी", "एकासी", "बयासी", "त्रियासी", "चौरासी", "पचासी", "छयासी", "सतासी", "अठासी", "उनान्नब्बे", "नब्बे", "एकान्नब्बे", "बयानब्बे", "त्रियान्नब्बे", "चौरान्नब्बे", "पन्चानब्बे", "छयान्नब्बे", "सन्तान्नब्बे", "अन्ठान्नब्बे", "उनान्सय", "सय" };

        //    string[] powers = new string[] { "हजार ", "लाख", "करोड", "अर्ब", "खर्ब" };

        //    string wordNumber = "";

        //    while (wholePart > 99)
        //    {
        //        char[] wholeNumberIntoCharacterArray = wholePart.ToString().ToCharArray();

        //        if (wholeNumberIntoCharacterArray.Length < 4)
        //        {
        //            int hundredNumber = Convert.ToInt32(Math.Floor(Convert.ToDecimal(wholePart / 100)));
        //            wordNumber += $"{numbersUptoHundred[hundredNumber]} {numbersUptoHundred[100]} ";
        //            wholePart = Convert.ToInt32(wholePart % 100);
        //        }
        //        else
        //        {
        //            //get index of power
        //            int powerIndex = 0;
        //            int lengthOfNumber = wholeNumberIntoCharacterArray.Length;
        //            bool isLengthOfNumberEven = lengthOfNumber % 2 == 0;

        //            string divisibleNumberInStringFormat = "1";

        //            int numberOfZerosInDivisibleNumber = 0;

        //            if (isLengthOfNumberEven)
        //            {
        //                powerIndex = (lengthOfNumber - 4) / 2;
        //                numberOfZerosInDivisibleNumber = lengthOfNumber - 1;
        //            }
        //            else
        //            {
        //                numberOfZerosInDivisibleNumber = lengthOfNumber - 2;
        //                powerIndex = ((lengthOfNumber - 1) - 4) / 2;
        //            }
        //            for (int i = 0; i < numberOfZerosInDivisibleNumber; i++)
        //            {
        //                divisibleNumberInStringFormat += "0";
        //            }

        //            int divisibleNumber = Convert.ToInt32(divisibleNumberInStringFormat);

        //            int tensNumber = Convert.ToInt32(Math.Floor(Convert.ToDecimal(wholePart / divisibleNumber)));

        //            wordNumber += $"{numbersUptoHundred[tensNumber]} {powers[powerIndex]} ";

        //            wholePart = Convert.ToInt32(wholePart % divisibleNumber);
        //        }
        //    }

        //    if (wholePart > 0)
        //    {
        //        wordNumber += $" {numbersUptoHundred[wholePart]}";
        //    }
        //    wordNumber += " रूपैया";

        //    wordNumber = appendPaisaIfPaisaPresent(arrNumber, numbersUptoHundred, wordNumber);

        //    return wordNumber;
        //}

        //private static string appendPaisaIfPaisaPresent(string[] arrNumber, string[] numbersUptoHundred, string wordNumber)
        //{
        //    bool isNumberDecimal = arrNumber.Length == 2;
        //    if (isNumberDecimal)
        //    {
        //        int paisa = Convert.ToInt32(arrNumber[1]);
        //        if (paisa > 0)
        //        {
        //            int indexOfPaisa = paisa > 9 ? paisa : (paisa * 10);
        //            wordNumber += $" {numbersUptoHundred[indexOfPaisa]} पैसा";
        //        }
        //    }

        //    return wordNumber;
        //}

        //        public string NumberToWord(string numberToConvert)
        //        {
        //            double num = Convert.ToInt32(numberToConvert);
        //            string word = null;

        //            String Ones(String numberToConvert)
        //            {
        //                switch (num)
        //                {
        //                    case 1:
        //                        word = "ONE";
        //                        break;
        //                    case 2:
        //                        word = "TWO";
        //                        break;
        //                    case 3:
        //                        word = "THREE";
        //                        break;
        //                    case 4:
        //                        word = "FOUR";
        //                        break;
        //                    case 5:
        //                        word = "FIVE";
        //                        break;
        //                    case 6:
        //                        word = "SIX";
        //                        break;
        //                    case 7:
        //                        word = "SEVEN";
        //                        break;
        //                    case 8:
        //                        word = "EIGHT";
        //                        break;
        //                    case 9:
        //                        word = "NINE";
        //                        break;
        //                }

        //                return word;
        //            }

        //            return word;

        //        }

        //        public String Tens(String numberToConvert)
        //        {
        //            double num = Convert.ToInt32(numberToConvert);
        //            String word = null;

        //            switch (num)
        //            {
        //                case 10:
        //                    word = "TEN";
        //                    break;
        //                case 11:
        //                    word = "ELEVEN";
        //                    break;
        //                case 12:
        //                    word = "TWELVE";
        //                    break;
        //                case 13:
        //                    word = "THIRTEEN";
        //                    break;
        //                case 14:
        //                    word = "FOURTEEN";
        //                    break;
        //                case 15:
        //                    word = "FIFTEEN";
        //                    break;
        //                case 16:
        //                    word = "SIXTEEN";
        //                    break;
        //                case 17:
        //                    word = "SEVENTEEN";
        //                    break;
        //                case 18:
        //                    word = "EIGHTEEN";
        //                    break;
        //                case 19:
        //                    word = "NINETEEN";
        //                    break;
        //                case 20:
        //                    word = "TWENTY";
        //                    break;
        //                case 30:
        //                    word = "THIRTY";
        //                    break;
        //                case 40:
        //                    word = "FOURTY";
        //                    break;
        //                case 50:
        //                    word = "FIFTY";
        //                    break;
        //                case 60:
        //                    word = "SIXTY";
        //                    break;
        //                case 70:
        //                    word = "SEVENTY";
        //                    break;
        //                case 80:
        //                    word = "EIGHTY";
        //                    break;
        //                case 90:
        //                    word = "NINETY";
        //                    break;
        //                    //default:


        //                    //    word = Tens(numberToConvert.Substring(0, 1) + "0") + Ones(numberToConvert.Substring(1, 1));

        //                    //    break;

        //            }
        //            return word;
    }

}

