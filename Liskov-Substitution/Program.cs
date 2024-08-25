using Liskov_Substitution;

var r = new Rectangle(10, 20);
Console.WriteLine($"Rectangle (10, 20) Area: {r.GetArea()}");

var sqr = new Square(10);
r = new Square(10);
Console.WriteLine($"Square (10,10) Area: {r.GetArea()}");
Console.WriteLine($"Square (10,10) Area: {sqr.GetArea()}");

r.Width = 20;
var area = r.GetArea();
Console.WriteLine($"Rectangle (20,10) Area: {area}");

Rectangle rect = new Square(10);
rect.Width = 20;
Console.WriteLine($"Rectangle (20,10) Area: {rect.GetArea()}");

if (area != 200)
{
    Console.WriteLine("What the hell???");
}