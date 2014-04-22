using System;

namespace DelegateDemoApp
{
  public class FuncAsParameterExample
  {
    public static void Execute()
    {
      TestIt(10, i => i < 25);
      TestIt(40, i => i < 25);

      // doesn't have to be an anonymous method, either
      TestIt(10, BeingExplicit);
    }

    private static bool BeingExplicit(int numberin)
    {
      return numberin < 25;
    }

    private static void TestIt(int numberIn, Func<int, bool> testComparison)
    {
      Console.WriteLine(testComparison(numberIn) ? "Passes test" : "Fails test");
    }
  }
}
