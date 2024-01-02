// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var a = 10;
var b = 2;

// Addition
var result = MyFirstClassLibrary.CalculatorMethods.Add(a, b);
Console.WriteLine(a + " + " + b + " = " + result);

// Subtraction
result = MyFirstClassLibrary.CalculatorMethods.Subtract(a, b);
Console.WriteLine(a + " - " + b + " = " + result);

// Multiplication
result = MyFirstClassLibrary.CalculatorMethods.Multiply(a, b);
Console.WriteLine(a + " * " + b + " = " + result);

// Division
result = MyFirstClassLibrary.CalculatorMethods.Divide(a, b);
Console.WriteLine(a + " / " + b + " = " + result);

