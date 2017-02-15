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
        if (_score >= 128)
        {
          _score -=128;
          _allergyList.Add("Cats");
        }
        if (_score >= 64)
        {
          _score -=64;
          _allergyList.Add("Pollen");
        }
        if(_score >= 32)
        {
          _score -=32;
          _allergyList.Add("Chocolate");
        }
        if (_score >= 16)
        {
          _score -=16;
          _allergyList.Add("Tomatoes");
        }
        if (_score >= 8)
        {
          _score -=8;
          _allergyList.Add("Strawberries");
        }
        if(_score >= 4)
        {
          _score -=4;
          _allergyList.Add("Shellfish");
        }
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
