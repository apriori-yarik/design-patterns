// See https://aka.ms/new-console-template for more information
using RecursiveGenerics;

var person = new EmployeeBuilder()
    .Salary(123000)
    .WorksAt("google")
    .Name("Pesho")
    .Age(50)
    .IsMale(true)
    .Build();

var person2 = new EmployeeBuilder()
    .Salary(123000)
    .Name("Pesho")
    .WorksAt("google")
    .Age(50)
    .IsMale(true)
    .Build();
