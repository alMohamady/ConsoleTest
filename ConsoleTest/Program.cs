// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;



//var order = GetData.GetCustomers()
//                   .OrderBy(x => x.age).First(x => x.age > 30);

var theOrdr = GetData.GetOrders().FirstOrDefault(x => x.Id > 1 ,new Order() { total= 10 });




//var order2 = (from o in GetData.GetCustomers()
//             orderby o.age descending
//             select o).First();
  
//Console.WriteLine("Id: {0} , name: {1}, age: {2} " 
//        , order.id, order.name, order.age);

Console.WriteLine("====================================");

//Console.WriteLine("Id: {0} , name: {1}, age: {2} "
//      , order2.id, order2.name, order2.age);