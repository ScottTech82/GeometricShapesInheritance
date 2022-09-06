
using GeometricShapes;

Console.WriteLine("Geometric Shapes");

Quad q2 = new Rect(1, 2);
var p = q2.Perimeter();
Rect r2 = new Sqr(3);
//Console.WriteLine($"{r2.Print()}");

Quad q1 = new(3, 4, 5, 6);
//Console.WriteLine($"Quad: {q1.Print()}");

Rect r1 = new(3, 5);
//Console.WriteLine($"Rectangle Perimeter is {r1.Perimeter()} and Area is {r1.Area()}");
//Console.WriteLine($"Rect: {r1.Print()}");

Sqr s1 = new(5);
//Console.WriteLine($"Square Perimeter is {s1.Perimeter()} and Area is {s1.Area()}");
//Console.WriteLine($"Sqr: {s1.Print()}");

//all are considered quads with 4 sides, unless we put Virtual and Override on the Method in each class
//then it prints differently in each class.
Quad[] quads = { q1, r1, s1 }; 
foreach(Quad q in quads)
{
    Console.WriteLine(q.Print());
}
