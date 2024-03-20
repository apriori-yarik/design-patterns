using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IPrinter
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
