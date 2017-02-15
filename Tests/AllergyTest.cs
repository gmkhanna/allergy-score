using System.Collections.Generic;
using System;
using Xunit;

namespace Allergy
{
  public class AllergyTest
  {

    [Fact]
    public void Test_NoAllergy_None()
    {
      int inputZero = 0;
      Allergy testZero = new Allergy(inputZero);
      List<string> result = testZero.Score();
      List<string> originList = new List<string> {"You have no allergies"};

      Assert.Equal(originList, result);
    }

    [Fact]
    public void Test2_EggAllergy_Eggs()
    {
      int inputEggs = 3;
      Allergy testEggs = new Allergy(inputEggs);
      List<string> result = testEggs.Score();
      List<string> originList = new List<string> {"Peanuts", "Eggs"};

      Assert.Equal(originList, result);
    }

  }
}
