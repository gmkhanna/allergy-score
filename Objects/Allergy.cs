using System.Collections.Generic;
using System;

namespace Allergy
{
  public class Allergy
  {
    private int _score;
    // private List<string> ____ = new List<string>();

    public Allergy(int score)
    {
      _score = score;
    }

    public string Score()
    {
      return "You have no allergies";
    }
  }
}
