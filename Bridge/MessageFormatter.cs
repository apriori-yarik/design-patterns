﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class MessageFormatter
    {
        public virtual string FormatMessage(string message)
        {
            return message;
        }
    }
}
