using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _007
{
  public class Calculator
  {
    public static int FindPrimeNumber(int value)
    {
      int numberOfPrimesFound = 0;
      int lastPrimeFound = 0;

      for (int i = 1 ; numberOfPrimesFound < value ; i++)
      {
        if (i.IsPrime())
        {
          lastPrimeFound = i;
          numberOfPrimesFound++;
        }
      }

      return lastPrimeFound;
    }
  }
}
