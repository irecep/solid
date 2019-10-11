using System;
using System.Collections.Generic;

namespace solid.Models.Notification
{
    public interface IMessage
    {
        IList<string> ToList { get; set; }
        string Subject { get; set; }
        string Message { get; set; }
    }
}
