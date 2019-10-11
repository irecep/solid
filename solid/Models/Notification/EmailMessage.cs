using System;
using System.Collections.Generic;

namespace solid.Models.Notification
{
    //isp
    public class EmailMessage : IMessage
    {
        public IList<string> ToList { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public EmailMessage()
        {
        }
    }
}
