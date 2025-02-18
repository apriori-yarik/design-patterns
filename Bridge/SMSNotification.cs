using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SMSNotification : Notification
    {
        public SMSNotification(MessageFormatter messageFormatter) : base(messageFormatter)
        {

        }

        public override void Send(string message)
        {
            Console.WriteLine($"SMS notification: {messageFormatter.FormatMessage(message)}");
        }
    }
}
