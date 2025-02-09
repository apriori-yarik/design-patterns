using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class FileSystem
    {
        private string rootPath;

        public IEnumerable<string> Files
        {
            get
            {
                IEnumerable<string> TraverseFiles(string root)
                {
                    var files = Directory.GetFiles(root);
                    var directories = Directory.GetDirectories(root);

                    foreach (var file in files)
                    {
                        yield return file;
                    }

                    foreach (var dir in directories)
                    {
                        foreach (var subfile in TraverseFiles(dir))
                        {
                            yield return subfile;
                        }
                    }
                }

                foreach (var element in TraverseFiles(rootPath))
                {
                    yield return element;
                }
            }
        }

        public FileSystem(string rootPath)
        {
            this.rootPath = rootPath;   
        }

        public FileSystemIterator GetEnumerator()
        {
            return new FileSystemIterator(rootPath);
        }
    }
}
