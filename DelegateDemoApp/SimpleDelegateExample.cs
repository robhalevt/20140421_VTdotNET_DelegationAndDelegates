using DelegateDemo;

namespace DelegateDemoApp
{
  public class SimpleDelegateExample
  {
    public static void Execute()
    {
      var generator = new NumberGenerator();
      SimpleThing d = generator.ReturnFive;
      d();
    }
  }
}
