using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class ActionExample
  {
    public static void Execute()
    {
      var actor = new Doer();

      // http://msdn.microsoft.com/en-us/library/system.action(v=vs.110).aspx
      Action action = actor.DoSomething;
      action();

      // http://msdn.microsoft.com/en-us/library/018hxwa8(v=vs.110).aspx
      Action<int> anotherAction = actor.DoSomethingSpecial;
      anotherAction += Console.WriteLine;
      anotherAction(6);
    }
  }
}
