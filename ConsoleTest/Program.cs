// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

var result = GetData.GetCustomers().Where(x => x.categoryId == 1);
//.ToList();
//.ToArray();
//.ToDictionary(x => x.categoryId);


var l1 = Enumerable.Range(0, 10);
var l2 = Enumerable.Range(5, 15);

//var ls = l1.Union(l2);
//var ls = l1.Concat(l2);
//ls = ls.Distinct();

//var ls = l1.Except(l2);
var ls = l1.Intersect(l2);

foreach (var x in ls)
    Console.WriteLine(x);