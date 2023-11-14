// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

var cats = GetData.GetCategories();
var custs = GetData.GetCustomers();

var result = cats.Join(custs,
                       cat => cat.Id, cust => cust.categoryId, 
                       (cat , cust) => new { 
                           fullName = cust.name, 
                           catName = cat.Name,
                       });

foreach(var item in result)
    Console.WriteLine(item.fullName + ":" + item.catName);

Console.WriteLine("=======================================");

var result2 = from cat in cats
              join cust in custs
              on cat.Id equals cust.categoryId
              select new
              {
                  fullName = cust.name,
                  catName = cat.Name,
              };

foreach (var item in result2)
    Console.WriteLine(item.fullName + ":" + item.catName);