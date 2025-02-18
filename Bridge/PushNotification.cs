using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PushNotification : Notification
    {
        public PushNotification(MessageFormatter messageFormatter) : base(messageFormatter)
        {

        }

        public override void Send(string message)
        {
            Console.WriteLine($"Push notification: {messageFormatter.FormatMessage(message)}");
        }
    }
}
