using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _010
{
  [DebuggerDisplay("Value: {Value}, IsMarked: {IsMarked}")]
  public class NaturalNumber
  {
    public long Value { get; private set; }
    public bool IsMarked { get; private set; }

    public NaturalNumber(long value)
    {
      Value = value;
      IsMarked = false;
    }

    public void Mark()
    {
      IsMarked = true;
    }
  }
}
