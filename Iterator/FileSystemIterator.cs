using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class FileSystemIterator
    {
        private Queue<string> q;
        private string root;

        public string Current { get; set; }

        public FileSystemIterator(string root)
        {
            Current = this.root = root;
            q = new Queue<string>();
            q.Enqueue(root);
        }

        public bool MoveNext()
        {
            if (!q.Any())
            {
                return false;
            }

            Current = q.Dequeue();

            if (!Current.Contains("."))
            {
                foreach (var item in Directory.GetDirectories(Current))
                {
                    q.Enqueue(item);
                }

                foreach (var item in Directory.GetFiles(Current))
                {
                    q.Enqueue(item);
                }
            }

            return true;
        }

        public void Reset()
        {
            q.Clear();
            Current = root;
        }
    }
}
