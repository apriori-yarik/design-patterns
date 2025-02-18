using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class EmailNotification : Notification
    {
        public EmailNotification(MessageFormatter messageFormatter) : base(messageFormatter)
        {

        }

        public override void Send(string message)
        {
            Console.WriteLine($"Email notification: {messageFormatter.FormatMessage(message)}");
        }
    }
}
