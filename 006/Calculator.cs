using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _006
{
  public class Calculator
  {
    public static int FindDifferenceBetweenSumOfTheSquaresAndSquareOfTheSumsForNaturalNumbersFromOneTo(int value)
    {
      int sumOfTheSquares = FindSumOfTheSquares(value);
      int squareOfTheSumes = FineSquareOfTheSums(value);

      return Math.Abs(sumOfTheSquares - squareOfTheSumes);
    }

    private static int FindSumOfTheSquares(int value)
    {
      int sum = 0;

      for (int i = 1 ; i <= value ; i++)
      {
        sum += (i * i);
      }

      return sum;
    }

    private static int FineSquareOfTheSums(int value)
    {
      int sum = 0;

      for (int i = 1 ; i <= value ; i++)
      {
        sum += i;
      }

      return sum * sum;
    }
  }
}
