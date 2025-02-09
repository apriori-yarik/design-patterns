// See https://aka.ms/new-console-template for more information

using Iterator;

FileSystem fs = new FileSystem(@"D:\test");

Console.WriteLine("C# style:");
foreach (var item in fs.Files)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------------------");

Console.WriteLine("C++ style:");
foreach (var item in fs)
{
    Console.WriteLine(item);
}

