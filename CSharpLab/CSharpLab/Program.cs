
using CSharpLab;

int a;
int b;

Console.Write("Num1: ");
a = int.Parse(Console.ReadLine()!);

Console.Write("Num2: ");
b = int.Parse(Console.ReadLine()!);

var c = new Calculator();
var sum = c.Add(a, b);

Console.WriteLine("-----");

Console.WriteLine($"Sum: {a} + {b} = {sum}");