using System;
using System.Collections.Generic;
using System.Linq;
using DelegateDemo;

namespace DelegateDemoApp
{
  public class PredicateExample
  {
    public static void Execute()
    {
      var employees = new List<Employee>
                        {
                          new Employee("Rob", 5),
                          new Employee("Dave", 3),
                          new Employee("Ann", 7),
                          new Employee("Grace", 1),
                          new Employee("Bill", 6),
                          new Employee("Henry", 2),
                          new Employee("June", 7),
                          new Employee("Pat", 4)
                        };

      Predicate<Employee> newHireFinder = employee => employee.YearsOfService <= 1;
      Predicate<Employee> vetranFinder = employee => employee.YearsOfService >= 5;
      
      foreach (var employee in employees.FindAll(vetranFinder))
      {
        Console.WriteLine("{0}: {1} years", employee.Name, employee.YearsOfService);
      }

      // the .Where extension method is on IEnumberable<T> - so it can't use the type
      // Predicate<T>.  However same results can be acheived using Func<T, bool>
      Func<Employee, bool> vetranFinder2 = employee => employee.YearsOfService >= 5;
      Console.WriteLine();
      foreach (var employee in employees.Where(vetranFinder2))
      {
        Console.WriteLine("{0}: {1} years", employee.Name, employee.YearsOfService);
      }
    }
  }
}
