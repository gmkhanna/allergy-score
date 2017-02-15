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
      string result = testZero.Score();

      Assert.Equal("You have no allergies", result);
    }
  }
}
