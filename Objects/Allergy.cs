using System.Collections.Generic;
using System;

namespace Allergy
{
  public class Allergy
  {
    private int _score;
    private List<string> _allergyList = new List<string>();

    public Allergy(int score)
    {
      _score = score;

    }

    public List<string> Score()
    {
      if (_score == 0)
      {
        _allergyList.Add("You have no allergies");
      }
      else
      {
        if (_score >= 2)
        {
          _score -=2;
          _allergyList.Add("Peanuts");
        }
        if(_score >= 1)
        {
          _score -=1; 
          _allergyList.Add("Eggs");
        }
      }
      return _allergyList;
    }
  }
}
