using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class DelegateDeclarationStyles
  {
    public static void Execute()
    {
      /* These are all equivalent, lambda syntax is the recommendation, though */
      SlightlyMoreComplexThing superExplicitThing = BeingExplicit;
      SlightlyMoreComplexThing aDelegateThang = delegate(int numberIn) { return numberIn < 25; };
      SlightlyMoreComplexThing lambdaThing = i => i < 25;

      Console.WriteLine("Should all be true{0}{1}", Environment.NewLine, new string('-', 20));
      Console.WriteLine(superExplicitThing(5));
      Console.WriteLine(aDelegateThang(5));
      Console.WriteLine(lambdaThing(5));
      Console.WriteLine();
      Console.WriteLine("Should all be false{0}{1}", Environment.NewLine, new string('-', 20));
      Console.WriteLine(superExplicitThing(50));
      Console.WriteLine(aDelegateThang(50));
      Console.WriteLine(lambdaThing(50));
    }

    private static bool BeingExplicit(int numberin)
    {
      return numberin < 25;
    }
  }
}
