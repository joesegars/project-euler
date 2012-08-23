using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _012
{
  public class FactorFinder
  {
    public static int FindTotalNumberOfFactorsFor(int value)
    {
      int totalFactors = 0;

      for (int i = 1 ; i <= value ; i++)
      {
        if (i.IsFactorOf(value))
        {
          totalFactors++;
        }
      }

      return totalFactors;
    }
  }
}