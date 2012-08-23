using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _012
{
  public class Calculator
  {
    public static int FindFirstTriangleNumberWithFactorsTotalingMoreThan(int value)
    {
      int returnValue = 0;
      int totalFactors = 0;

      for (int i = value ; totalFactors < value ; i++)
      {
        int triangleNumber = TriangleNumberCalculator.CalculateTriangleNumberOf(i);
        totalFactors = FactorFinder.FindTotalNumberOfFactorsFor(triangleNumber);

        if (totalFactors > value)
        {
          returnValue = triangleNumber;
          
        }
      }

      return returnValue;
    }
  }
}