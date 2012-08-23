using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _008
{
  public class Calculator
  {
    public static int FindGreatestProductOfFiveConsecutiveNumbersIn(string value)
    {
      int greatestProduct = 0;

      if (value.IsAtLeastFiveCharactersLong())
      {
        int startIndex = 0;
        int substringLength = 5;

        while (startIndex < value.Length - 4)
        {
          FiveDigitString fiveDigitString = new FiveDigitString(value.Substring(startIndex, substringLength));
          int product = fiveDigitString.CalculateProductOfEachValue();

          greatestProduct = Math.Max(product, greatestProduct);

          startIndex++;
        }
      }

      return greatestProduct;
    }
  }
}
