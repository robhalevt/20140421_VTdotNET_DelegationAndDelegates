using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class MulticastDelegateValueProblem
  {
    public static void Execute()
    {
      // example comes from http://msdn.microsoft.com/en-us/library/orm-9780596516109-03-09.aspx
      var generator = new NumberGenerator();
      SimpleThing d = generator.ReturnFive;
      d += generator.ReturnTen;
      d += generator.ReturnThirty;
      Console.WriteLine(d());      
    }
  }
}
