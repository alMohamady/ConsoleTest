// See https://aka.ms/new-console-template for more information
using ConsoleTest.Extentions;
using SeedData;

Console.WriteLine("Hello, World!");

//var ahmedList = Filter.getAhmeds(GetData.GetCustomers());
var ahmedList = GetData.GetCustomers().getByName("mohmed");


foreach (var ahmed in ahmedList)
{
    Console.WriteLine($" name {ahmed.name} : age {ahmed.age} ");
}




