using System;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class DelegateAsParameter
  {
    public static void Execute()
    {
      var actor = new Doer();
      
      // doesn't matter how we declare the delegate method...
      DoSomethingWithANumber thingToDo = i => Console.WriteLine(i * 2);
      actor.ActUponANumber(5, thingToDo);
      actor.ActUponANumber(5, actor.DoSomethingSpecial);
      actor.ActUponANumber(5, i => Console.WriteLine(new string('*', i)));
    }
  }
}
