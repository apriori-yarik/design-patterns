using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Scenario1
{
    public class File : FileSystemItem
    {
        public int Size { get; set; }
        public override string Type => "File";

        public File(string name, int size) : base(name)
        {
            Size = size;
        }

        public override string Info()
        {
            return $"{Type} | {Name} | {Size} kB";
        }

        public override string ToString()
        {
            return Info();
        }
    }
}
