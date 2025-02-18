using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class HTMLFormatter : MessageFormatter
    {
        public override string FormatMessage(string message)
        {
            return $"<p>{message}</p>";
        }
    }
}
