using System;
using System.Linq;

namespace DelegateDemoApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Use an action to drive menu and execution of delegate examples
      Action examples = SimpleDelegateExample.Execute;
      examples += MulticastDelegateValueProblem.Execute;
      examples += MulticastDelegateValueFix.Execute;
      examples += MulticastDelegateExceptionProblem.Execute;
      examples += MulticastDelegateExceptionFix.Execute;
      examples += DelegateDeclarationStyles.Execute;
      examples += DelegateAsParameter.Execute;
      examples += ActionExample.Execute;
      examples += FuncExample.Execute;
      examples += FuncAsParameterExample.Execute;
      examples += PredicateExample.Execute;

      RenderMenu(examples);

      var selectedIndex = IdentifySelection(examples);
      if (selectedIndex > (examples.GetInvocationList().Count() - 1))
      {
        return;
      }

      ExecuteDelegateExample(examples, selectedIndex);

      Console.ReadLine();
    }

    private static void ExecuteDelegateExample(Action examples, int selectedIndex)
    {
      var counter = 0;
      foreach (Action action in examples.GetInvocationList())
      {
        if (counter.Equals(selectedIndex))
        {
          Console.WriteLine("{1}{0}{1}{2}", action.Method.DeclaringType, Environment.NewLine, new string('-', 20));
          try
          {
            action();
          }
          catch (Exception exception)
          {
            Console.WriteLine(exception);
          }

          break;
        }

        counter++;
      }
    }

    private static void RenderMenu(Action examples)
    {
      Console.WriteLine("Select an example:");
      for (int i = 0; i < examples.GetInvocationList().Count(); i++)
      {
        var action = examples.GetInvocationList().ToArray()[i];
        Console.WriteLine("  {0} - {1}", i, action.Method.DeclaringType.Name);
      }

      Console.Write(">");
    }

    private static int IdentifySelection(Action examples)
    {
      var selection = Console.ReadLine();

      int index;
      if (!int.TryParse(selection, out index))
      {
        // put it out of range
        index = examples.GetInvocationList().Count();
      }

      return index;
    }
  }
}
