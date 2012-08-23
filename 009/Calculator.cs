using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _009
{
  public class Calculator
  {
    public static PythagoreanTriplet FindProductOfPythagoreanTripletWhoseSumIsOneThousand()
    {
      /*
       *  The following will generate all Pythagorean triples (although not uniquely):
       *  where m, n, and k are positive integers with m > n.
       *  
       *  a = k * (m^2 - n^2)
       *  b = k * (2mn)
       *  c = k * (m^2 + n^2)
       */

      for (int n = 1 ; n < 1000 ; n++)
      {
        for (int m = n + 1 ; m < 1000 ; m++)
        {
          for (int k = 1 ; k < 1000 ; k++)
          {
            PythagoreanTriplet triplet = PythagoreanTriplet.DeriveTriplet(m, n, k);
            
            if (triplet.SumValues() == 1000)
            {
              return triplet;
            }
          }
        }
      }

      return null;
    }
  }
}
