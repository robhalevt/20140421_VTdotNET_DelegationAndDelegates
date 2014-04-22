using System;

namespace DelegateDemo
{
  // the idea for these methods came from a series about delegates by https://www.youtube.com/user/1kingja
  public class NumberGenerator
  {
    public int ReturnFive()
    {
      Console.WriteLine(
        "{0}.{1}", 
        System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
        System.Reflection.MethodBase.GetCurrentMethod().Name);
      return 5;
    }

    public int ReturnTen()
    {
      Console.WriteLine(
        "{0}.{1}",
        System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
        System.Reflection.MethodBase.GetCurrentMethod().Name);
      return 10;
    }

    public int ReturnThirty()
    {
      Console.WriteLine(
        "{0}.{1}",
        System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
        System.Reflection.MethodBase.GetCurrentMethod().Name);
      return 30;
    }

    public int ReturnFiftyFour()
    {
      Console.WriteLine(
        "{0}.{1}", 
        System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
        System.Reflection.MethodBase.GetCurrentMethod().Name);
      throw new NotSupportedException("whoops");
    }
  }
}
