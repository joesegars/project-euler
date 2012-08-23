using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _003
{
  public class Calculator
  {
    public static long FindLargestPrimeFactorOf(long value)
    {
      if (value == 0)
      {
        return 0;
      }

      /*
       * Factors would be (value / i)...if you start i at 2 that will give you the largest possible factor.
       * If it's prime you're done, if it's not then go to the next largest factor (i=3).  Rinse and Repeat.
       */
      for (long i = 1 ; i <= value ; i++)
      {
        if (i.IsFactorOf(value))
        {
          long possiblePrime = value / i;
          if (possiblePrime.IsPrime())
          {
            return possiblePrime;
          }
        }
      }

      return 0;
    }
  }
}
