// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;



var orderList = GetData.GetCustomers()
                .OrderByDescending(x => x.age)
                .ThenBy(x => x.name);
                //.OrderBy(x => x.age);

var orderList2 = from o in GetData.GetCustomers()
                 orderby o.age descending, o.name descending
                 select o;

foreach (var order in orderList)   
    Console.WriteLine("Id: {0} , name: {1}, age: {2} " 
        , order.id, order.name, order.age);

Console.WriteLine("====================================");

foreach (var order in orderList2)
    Console.WriteLine("Id: {0} , name: {1}, age: {2} "
        , order.id, order.name, order.age);