using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
  public static class LongExtensions
  {
    public static bool IsFactorOf(this long possibleFactor, long value)
    {
      return value % possibleFactor == 0;
    }

    public static bool IsPrime(this long value)
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

    public static bool IsEven(this long value)
    {
      if (value % 2 == 0)
      {
        return true;
      }

      return false;
    }
  }
}
