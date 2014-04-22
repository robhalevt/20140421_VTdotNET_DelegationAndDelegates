using System;

namespace DelegationExample
{
  class ConsoleScreenWriter : IScreenWriter
  {
    public void Write(string message)
    {
      Console.WriteLine("ConsoleScreenWriter - {0}", message);
    }
  }
}
