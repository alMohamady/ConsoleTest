// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

var cats = GetData.GetCategories();
var custs = GetData.GetCustomers();

var result = custs.GroupBy(c => c.categoryId); // Deferred
var resultlp = custs.ToLookup(c => c.categoryId); // Immediate

foreach (var g in result)
{
    Console.WriteLine($"Category Number: {g.Key}");
    foreach (var c in g)
    {
        Console.WriteLine("------>" + c.name);
    }
}

Console.WriteLine("======================");

var result2 = from c in custs
              group c by c.categoryId;
var reusltTl = (from c in custs select c).ToLookup(c => c.categoryId);

foreach (var g in result2)
{
    Console.WriteLine($"Category Number: {g.Key}");
    foreach (var c in g)
    {
        Console.WriteLine("------>" + c.name);
    }
}
