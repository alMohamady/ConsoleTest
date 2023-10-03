// See https://aka.ms/new-console-template for more information




var c1 = new { id = 101, name = "ahmed mohmed", age = 30, isActive = true};
var c2 = new { id = 102, name = "ahmed ", age = 31, isActive = true };

var c3 = new { id = 102,  age = 31,name = "ahmed " };

var c4 = new { id = 101, name = "ahmed mohmed", age = 30, isActive = true };

Console.WriteLine(c1.GetType().Name);
Console.WriteLine(c2.GetType().Name);
Console.WriteLine(c3.GetType().Name);

Console.WriteLine(c1.Equals(c4));

var c5 = new { custId = 101, custName = "ahmed mohmed", custAge = 30, isActive = true };

Console.WriteLine(c5.GetType().Name);

Console.WriteLine(c1.Equals(c5));