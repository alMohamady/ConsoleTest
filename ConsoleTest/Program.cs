// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

var cats = GetData.GetCategories();
var custs = GetData.GetCustomers();

var result = cats.GroupJoin(custs,
                       cat => cat.Id, cust => cust.categoryId, 
                       (cat , cust) => new { 
                           myCustomers = cust, 
                           catName = cat.Name,
                       });

foreach (var item in result)
{
    Console.WriteLine("category :" + item.catName);
    if (item.myCustomers != null)
    {
        foreach (var c in item.myCustomers)
            Console.WriteLine("----->" + c.name);
    }
}

Console.WriteLine("=======================================");

var result2 = from cat in cats
              join cust in custs
              on cat.Id equals cust.categoryId
              into customers
              select new
              {
                  myCustomers = customers,
                  catName = cat.Name,
              };

foreach (var item in result2)
{
    Console.WriteLine("category :" + item.catName);
    if (item.myCustomers != null)
    {
        foreach (var c in item.myCustomers)
            Console.WriteLine("----->" + c.name);
    }
}
