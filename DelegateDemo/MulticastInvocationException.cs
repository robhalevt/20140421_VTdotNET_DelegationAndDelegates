using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace DelegateDemo
{
  [Serializable]
  public class MulticastInvocationException : Exception
  {
    private readonly List<Exception> _invocationExceptions;

    public MulticastInvocationException()
    {
    }

    public MulticastInvocationException(IEnumerable<Exception> invocationExceptions)
    {
      _invocationExceptions = new List<Exception>(invocationExceptions);
    }

    public MulticastInvocationException(string message)
      : base(message)
    {
    }

    public MulticastInvocationException(string message, Exception innerException)
      : base(message, innerException)
    {
    }

    protected MulticastInvocationException(SerializationInfo info, StreamingContext context) 
      : base(info, context)
    {
      _invocationExceptions =
          (List<Exception>)info.GetValue("InvocationExceptions",
              typeof(List<Exception>));
    }

    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("InvocationExceptions", InvocationExceptions);
      base.GetObjectData(info, context);
    }

    public ReadOnlyCollection<Exception> InvocationExceptions
    {
      get { return new ReadOnlyCollection<Exception>(_invocationExceptions); }
    }
  }
}
