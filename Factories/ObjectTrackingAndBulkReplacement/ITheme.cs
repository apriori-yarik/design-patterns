using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTrackingAndBulkReplacement
{
    public interface ITheme
    {
        public string TextColor { get; }
        public string BgrColor { get; }
    }
}
