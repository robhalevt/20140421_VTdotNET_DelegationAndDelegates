using System;
using log4net;

namespace DelegationExample
{
  class Program
  {
    static void Main(string[] args)
    {
      SimpleDelegationExample();
      
      Console.WriteLine();
      SlightlyMoreComplexDelegationExample();

      Console.ReadLine();
    }

    private static void SimpleDelegationExample()
    {
      Console.WriteLine("Running SimpleDelegationExample");
      var logger = LogManager.GetLogger("Simple Delegation");
      logger.Info("I'm delegating...");
    }

    private static void SlightlyMoreComplexDelegationExample()
    {
      Console.WriteLine("Running SlightlyMoreComplexDelegationExample");
      IScreenWriter writer = new Log4NetScreenWriter();
      writer.Write("I'm delegating...");
      writer = new ConsoleScreenWriter();
      writer.Write("I'm delegating again...");
    }
  }
}
