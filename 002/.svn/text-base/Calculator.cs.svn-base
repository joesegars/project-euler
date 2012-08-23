using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002
{
  public class Calculator
  {
    public static int SumAllEvenFibonacciValuesNotExceeding(int value)
    {
      if (value < 2)
      {
        return 0;
      }

      List<int> allFibonacciValues = DetermineAllFibonacciValuesBelow(value);

      return allFibonacciValues.Where(v => v % 2 == 0).Sum(x => x);
    }

    private static List<int> DetermineAllFibonacciValuesBelow(int value)
    {
      List<int> fibonacciValues = new List<int>();
      fibonacciValues.Add(1);
      fibonacciValues.Add(2);

      for (int i = 0, j = 1 ;  ; i++, j++)
      {
        var valueOne = fibonacciValues[i];
        var valueTwo = fibonacciValues[j];

        var nextFibonaccivalue = valueOne + valueTwo;

        if (nextFibonaccivalue <= value)
        {
          fibonacciValues.Add(valueOne + valueTwo);
        }
        else
        {
          break;
        }
      }

      return fibonacciValues;
    }
  }
}
