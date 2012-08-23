using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _009
{
  public class PythagoreanTriplet
  {
    public int A { get; private set; }
    public int B { get; private set; }
    public int C { get; private set; }

    public PythagoreanTriplet(int a, int b, int c)
    {
      A = a;
      B = b;
      C = c;
    }

    public int SumValues()
    {
      return A + B + C;
    }

    public int MultiplyValues()
    {
      return A * B * C;
    }

    public static bool IsPythagoreanTriplet(int a, int b, int c)
    {
      if (a > b || b > c || a > c)
      {
        return false;
      }

      return (a * a) + (b * b) == (c * c);
    }

    public static PythagoreanTriplet DeriveTriplet(int m, int n, int k)
    {
      int a = CalculateA(m, n, k);
      int b = CalculateB(m, n, k);
      int c = CalculateC(m, n, k);

      return new PythagoreanTriplet(a, b, c);
    }

    private static int CalculateA(int m, int n, int k)
    {
      return k * ((m * m) - (n * n));
    }

    private static int CalculateB(int m, int n, int k)
    {
      return k * 2 * m * n;
    }

    private static int CalculateC(int m, int n, int k)
    {
      return k * ((m * m) + (n * n));
    }
  }
}
