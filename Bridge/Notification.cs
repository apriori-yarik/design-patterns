using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Notification
    {
        protected readonly MessageFormatter messageFormatter;

        public Notification(MessageFormatter messageFormatter)
        {
            this.messageFormatter = messageFormatter;
        }

        public abstract void Send(string message);
    }
}
