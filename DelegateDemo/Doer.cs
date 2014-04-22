using System;

namespace DelegateDemo
{
  public class Doer
  {
    public void DoSomething()
    {
      Console.WriteLine("I'm doing something");
    }

    public void DoSomethingSpecial(int numberIn)
    {
      Console.WriteLine("I'm doing something with a {0}", numberIn);
    }

    public void ActUponANumber(int number, DoSomethingWithANumber thingToDo)
    {
      if (thingToDo == null)
      {
        throw new ArgumentNullException("thingToDo", "Need to provide something to do");
      }
      
      thingToDo(number);
    }
  }
}
