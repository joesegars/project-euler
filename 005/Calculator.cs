using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _005
{
  public class Calculator
  {
    public static int FindSmallestValueDivisibleByEachNumberInRange(int startValue, int endValue)
    {
      int smallestValue = 0;

      for (int i = 1 ; ; i++)
      {
        smallestValue = endValue * i;
        bool allValuesAreFactors = false;
        for (int k = startValue ; k < endValue ; k++)
        {
          allValuesAreFactors = k.IsFactorOf(smallestValue);
          if (!allValuesAreFactors)
          {
            break;
          }
        }

        if (allValuesAreFactors)
        {
          break;
        }
      }
      

      return smallestValue;
    }
  }
}
