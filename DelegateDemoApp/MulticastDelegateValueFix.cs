using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class MulticastDelegateValueFix
  {
    public static void Execute()
    {
      // example comes from http://msdn.microsoft.com/en-us/library/orm-9780596516109-03-09.aspx
      var generator = new NumberGenerator();
      var d = new SimpleThing(generator.ReturnFive);
      d += generator.ReturnTen;
      d += generator.ReturnThirty;

      foreach (SimpleThing thing in d.GetInvocationList())
      {
        Console.WriteLine(thing());
      }
    }
  }
}
