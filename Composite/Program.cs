using Composite;

var file1 = new Composite.File("composite.txt", 2);
var file2 = new Composite.File("iterator.txt", 2);
var file3 = new Composite.File("facade.txt", 2);
var file4 = new Composite.File("decorator.txt", 2);

var root = new Composite.Directory("root", true);
var subdir1 = new Composite.Directory("subdir1", false);
var subdir2 = new Composite.Directory("subdir2", false);
var subdir3 = new Composite.Directory("subdir3", false);
var subdir4 = new Composite.Directory("subdir4", false);

root.Add(subdir1);
subdir1.Add(subdir3);
subdir1.Add(subdir4);
root.Add(subdir2);

root.Add(file1);
subdir3.Add(file2);
subdir2.Add(file3);
subdir2.Add(file4);

Console.WriteLine(root);