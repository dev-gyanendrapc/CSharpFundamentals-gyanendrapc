using Rectangle1;

// Rectangle rect = new(10,20.5);
// var a1 = rect.GetArea();
// var p1 = rect.GetPerimeter();
// System.Console.WriteLine(a1 + " " +p1);

// Square sqr = new(10.5);
// var a2 = sqr.GetArea();
// var p2 = sqr.GetArea();

// Circle crl = new(10.5);
// var a3 = sqr.GetArea();
// var p3 = sqr.GetArea();


IShape shape = new Rectangle(10,20.5);
var a1 = shape.GetArea();
var p1 = shape.GetPerimeter();
System.Console.WriteLine(a1 + " " +p1);

shape = new Square(10.5);
var a2 = shape.GetArea();
var p2 = shape.GetArea();
System.Console.WriteLine(a2 + " " +p2);

shape  = new Circle(10.5);
var a3 = shape.GetArea();
var p3 = shape.GetArea();
System.Console.WriteLine(a3 + " " +p3);

shape = new Triangle(10, 20.5, 13.6);
var a4 = shape.GetArea();
var p4 = shape.GetPerimeter();
System.Console.WriteLine(a4 + " " +p4);
