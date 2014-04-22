using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class MulticastDelegateExceptionProblem
  {
    public static void Execute()
    {
      // example comes from http://msdn.microsoft.com/en-us/library/orm-9780596516109-03-09.aspx
      var generator = new NumberGenerator();
      var d = new SimpleThing(generator.ReturnFive);
      d += generator.ReturnTen;
      d += generator.ReturnFiftyFour;
      d += generator.ReturnThirty;

      try
      {
        Console.WriteLine(d());
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception);
      }
    }
  }
}
