using System;

namespace DelegateDemoApp
{
  public class FuncExample
  {
    public static void Execute()
    {
      // http://msdn.microsoft.com/en-us/library/bb534960(v=vs.110).aspx
      Func<int, bool> func = BeingExplicit;
      Console.WriteLine(func(6));
      Console.WriteLine(func(60));
    }

    private static bool BeingExplicit(int numberin)
    {
      return numberin < 25;
    }
  }
}
