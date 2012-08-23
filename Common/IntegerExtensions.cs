using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
  public static class IntegerExtensions
  {
    public static bool IsMultipleOfThree(this int i)
    {
      return i % 3 == 0;
    }

    public static bool IsMultipleOfFive(this int i)
    {
      return i % 5 == 0;
    }

    public static bool IsFactorOf(this int possibleFactor, int value)
    {
      return value % possibleFactor == 0;
    }

    public static bool IsPrime(this int value)
    {
      if (value == 1)
      {
        return false;
      }

      if (value.IsEven() && value != 2)
      {
        return false;
      }

      for (int i = 1 ; i < value ; i = i + 2)
      {
        if (value % i == 0 && i != 1)
        {
          return false;
        }
      }

      return true;
    }

    public static bool IsEven(this int value)
    {
      if (value % 2 == 0)
      {
        return true;
      }

      return false;
    }

    public static bool IsPalindrome(this int value)
    {
      if (value < 10)
      {
        return true;
      }

      String valueAsString = new String(value.ToString().ToArray());
      String reversedString = new String(valueAsString.Reverse().ToArray());

      return valueAsString.Equals(reversedString);
    }
  }
}
