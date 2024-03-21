// See https://aka.ms/new-console-template for more information
// ordinary non-fluent builder
using HTMLBuilderDemo;
using static System.Console;

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
WriteLine(builder.ToString());

// fluent builder
builder.Clear(); // disengage builder from the object it's building, then...
builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
WriteLine(builder);
