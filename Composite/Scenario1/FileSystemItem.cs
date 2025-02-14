using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Scenario1
{
    public abstract class FileSystemItem
    {
        private Lazy<List<FileSystemItem>> children = new Lazy<List<FileSystemItem>>();
        public List<FileSystemItem> Children => children.Value;
        public string Name { get; set; }
        public abstract string Type { get; }

        public FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract string Info();

        public void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('-', depth));
            sb.AppendLine(Info());
            foreach (var item in Children)
            {
                item.Print(sb, depth + 2);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
    }
}
