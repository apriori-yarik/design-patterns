// See https://aka.ms/new-console-template for more information
using FunctionalBuilder;

var pb = new PersonBuilder();
var person = pb.Called("Dmitri").WorksAsA("Programmer").Build();
