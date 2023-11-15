// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

//var result = GetData.GetCustomers().Skip(2);
//var result = GetData.GetCustomers().SkipWhile(x => x.age < 25);
//var result = GetData.GetCustomers().SkipLast(5);

//var result = GetData.GetCustomers().Take(15);
//var result = GetData.GetCustomers().TakeWhile(x => x.age < 25);
var result = GetData.GetCustomers().TakeLast(5);

foreach (var item in result)
{
    Console.WriteLine(item.id + ":" + item.name + ":" + item.age);
}


