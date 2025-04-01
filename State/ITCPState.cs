using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface ITCPState
    {
        public void Open();
        public void Close();
        public void Acknowledge();
    }
}
