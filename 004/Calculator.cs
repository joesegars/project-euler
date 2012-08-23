using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _004
{
  public class Calculator
  {
    public static int FindLargestPalindromeMadeFromProductOfTwoTwoDigitNumbers()
    {
      for (int y = 99 ; y >= 10 ; y--)
      {
        for (int x = 99 ; x >= 10 ; x--)
        {
          int product = x * y;
          if (product.IsPalindrome())
          {
            return product;
          }
        }
      }

      return 0;
    }

    public static int FindLargestPalindromeMadeFromProductOfTwoThreeDigitNumbers()
    {
      int largestPalindrome = 0;

      for (int y = 999 ; y >= 100 ; y--)
      {
        for (int x = 999 ; x >= 100 ; x--)
        {
          int product = x * y;
          if (product.IsPalindrome() && product > largestPalindrome)
          {
            largestPalindrome = product;
          }
        }
      }

      return largestPalindrome;
    }
  }
}
