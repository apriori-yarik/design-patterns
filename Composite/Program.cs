using Composite.Scenario2;


// Scenario 1
var file1 = new Composite.Scenario1.File("composite.txt", 2);
var file2 = new Composite.Scenario1.File("iterator.txt", 2);
var file3 = new Composite.Scenario1.File("facade.txt", 2);
var file4 = new Composite.Scenario1.File("decorator.txt", 2);

var root = new Composite.Scenario1.Directory("root", true);
var subdir1 = new Composite.Scenario1.Directory("subdir1", false);
var subdir2 = new Composite.Scenario1.Directory("subdir2", false);
var subdir3 = new Composite.Scenario1.Directory("subdir3", false);
var subdir4 = new Composite.Scenario1.Directory("subdir4", false);

root.Add(subdir1);
subdir1.Add(subdir3);
subdir1.Add(subdir4);
root.Add(subdir2);

root.Add(file1);
subdir3.Add(file2);
subdir2.Add(file3);
subdir2.Add(file4);

Console.WriteLine(root);

// Scenario 2
var neuron1 = new Neuron();
var neuron2 = new Neuron();
var layer1 = new NeuronLayer();
var layer2 = new NeuronLayer();

neuron1.ConnectTo(neuron2);
neuron1.ConnectTo(layer1);
layer1.ConnectTo(layer2);