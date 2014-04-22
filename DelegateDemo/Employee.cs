namespace DelegateDemo
{
  public class Employee
  {
    public Employee(string name, int years)
    {
      Name = name;
      YearsOfService = years;
    }

    public string Name { get; set; }

    public int YearsOfService { get; set; }
  }
}
