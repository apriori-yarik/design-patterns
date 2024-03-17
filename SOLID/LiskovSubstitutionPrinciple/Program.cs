// See https://aka.ms/new-console-template for more information
using LiskovSubstitutionPrinciple;
using static System.Console;

int Area(Rectangle r) => r.Width * r.Height;

Rectangle rc = new Rectangle(2, 3);
WriteLine($"{rc} has area {Area(rc)}");

// should be able to substitute a base type for a subtype
// Square sq = new Square(); is equivalent to the line below
Rectangle sq = new Square();
sq.Width = 4;
WriteLine($"{sq} has area {Area(sq)}");
