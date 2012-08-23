using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _008
{
  public class FiveDigitString
  {
    private string _value;

    public FiveDigitString(string value)
    {
      if (value.IsExactlyFiveCharactersLong())
      {
        _value = value;
      }
      else
      {
        throw new Exception("value needs to be exactly five digits long");
      }
    }

    public int CalculateProductOfEachValue()
    {
      var product = 1;

      for (int i = 0 ; i < 5 ; i++)
      {
        product *= Convert.ToInt32(_value[i].ToString());
      }

      return product;
    }
  }
}
