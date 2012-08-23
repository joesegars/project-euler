using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010
{
  public class PrimeCalculator
  {
    private List<NaturalNumber> _naturalNumbers { get; set; }

    public PrimeCalculator()
    {
      _naturalNumbers = new List<NaturalNumber>();
    }

    public IEnumerable<NaturalNumber> FindAllPrimesBelow(int value)
    {
      InitializeList(value);
      MarkZeroAndOne();

      int p = 2;
      while (p != -1)
      {
        for (int index = p + p ; index < _naturalNumbers.Count() ; index += p)
        {
          _naturalNumbers[index].Mark();
        }

        p = (int)GetNextUnmarkedValueGreaterThan(p);
      }

      return _naturalNumbers.Where(nn => !nn.IsMarked);
    }

    private void MarkZeroAndOne()
    {
      _naturalNumbers[0].Mark();
      _naturalNumbers[1].Mark();
    }

    private long GetNextUnmarkedValueGreaterThan(int p)
    {
      for (int i = p + 1 ; i < _naturalNumbers.Count() ; i++)
      {
        if (!_naturalNumbers[i].IsMarked)
        {
          return _naturalNumbers[i].Value;
        }
      }

      return -1;
    }

    private void InitializeList(int value)
    {
      for (int i = 0 ; i < value ; i++)
      {
        _naturalNumbers.Add(new NaturalNumber(i));
      }
    }
  }
}
