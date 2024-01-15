using MyFirstProject;
using Newtonsoft.Json;

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

string json = @"{
  'XValue': 2,
  'YValue': 3,
  'Result': 0
}";

var m = JsonConvert.DeserializeObject<EquationValues>(json);

    if (m != null)
    {
        m.Result = MyFirstClassLibrary.CalculatorMethods.Add(m.XValue, m.YValue);
        Console.WriteLine(m.XValue + " + " + m.YValue + " = " + m.Result);
    } 
    else
    {
    Console.WriteLine("Error...: Could not deserialize json");
    }

