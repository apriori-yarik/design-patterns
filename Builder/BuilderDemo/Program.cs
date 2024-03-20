// See https://aka.ms/new-console-template for more information
using BuilderDemo;

var carBuilder = new CarBuilder();
Director.ConstructSportsCar(carBuilder);
var car = carBuilder.GetResult();
Console.WriteLine(car);

var manualBuilder = new ManualBuilder();
Director.ConstructSportsCar(manualBuilder);
var manual = manualBuilder.GetResult();
Console.WriteLine(manual.Text);
