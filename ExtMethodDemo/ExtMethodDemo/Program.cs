using ExtMethodDemo;



var p = new Person();

var car = new { Make = "Ford", Model = "Focus", Speed = 55 };
var car2 = new { Make = "Porsche", Speed = 155, Model = "Boxster" };

Console.WriteLine(car.GetType().Name);
Console.WriteLine(car2.GetType().Name);

