using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _010
{
  public class Calculator
  {
    public static long FindSumOfAllPrimesBelow(int value)
    {
      PrimeCalculator pc = new PrimeCalculator();
      IEnumerable<NaturalNumber> primes = pc.FindAllPrimesBelow(value);

      return primes.Sum(x => x.Value);
    }
  }
}
