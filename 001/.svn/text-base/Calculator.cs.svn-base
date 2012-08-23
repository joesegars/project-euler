using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _001
{
  public class Calculator
  {
    public static int SumAllMultiplesOfThreeOrFiveBelow(int value)
    {
      var sum = 0;

      for (int i = 0 ; i < value ; i++)
      {
        if (i.IsMultipleOfThree() || i.IsMultipleOfFive())
        {
          sum += i;
        }
      }

      return sum;
    }
  }
}
