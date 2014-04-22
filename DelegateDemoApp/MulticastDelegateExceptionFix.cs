using System;
using System.Collections.Generic;
using System.Linq;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class MulticastDelegateExceptionFix
  {
    public static void Execute()
    {
      // example comes from http://msdn.microsoft.com/en-us/library/orm-9780596516109-03-09.aspx
      var generator = new NumberGenerator();
      var d = new SimpleThing(generator.ReturnFive);
      d += generator.ReturnTen;
      d += generator.ReturnFiftyFour;
      d += generator.ReturnThirty;
      var exceptions = new List<Exception>();

      foreach (SimpleThing thing in d.GetInvocationList())
      {
        try
        {
          thing();
        }
        catch (Exception e)
        {
          Console.WriteLine("  Invocation of {0} failed", thing.Method.Name);
          exceptions.Add(e);
        }
      }

      if (!exceptions.Any())
      {
        return;
      }

      Console.WriteLine();
      throw new MulticastInvocationException(exceptions);
    }
  }
}
