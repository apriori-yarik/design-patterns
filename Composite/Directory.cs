using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Directory : FileSystemItem
    {
        public Directory(string name, bool isRoot) : base(name)
        {
            IsRoot = isRoot;
        }

        public bool IsRoot { get; set; }
        public override string Type => "Directory";

        public override string Info()
        {
            return $"{Type} | {Name}";
        }

        public override string ToString()
        {
            if (IsRoot)
            {
                return base.ToString();
            }
            return Info();
        }

        public void Add(FileSystemItem item)
        {
            Children.Add(item);
        }
    }
}
