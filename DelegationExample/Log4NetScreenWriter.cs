using log4net;

namespace DelegationExample
{
  class Log4NetScreenWriter : IScreenWriter
  {
    public void Write(string message)
    {
      var logger = LogManager.GetLogger("Log4NetScreenWriter");
      logger.Info(message);
    }
  }
}
