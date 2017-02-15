using Nancy;
using System.Collections.Generic;
using System;

namespace Allergy
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        int userInput = Request.Form["number"];
        Allergy newAmount = new Allergy(userInput);
        List<string> allergyList = newAmount.Score();
        return View["index.cshtml", allergyList];
      };
    }
  }
}
