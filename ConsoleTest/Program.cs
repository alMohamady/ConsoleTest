// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

List<String> names  = new List<String>()
{ "Ahmed Mohamady", "Mohamed Salah", "Zaki gom3a" };

var nums = Enumerable.Range(0, 10);

var result = names.Zip(nums);
var result2 = GetData.GetCustomers().Zip(nums, (c, i) => new { i, c.name });


foreach (var item in result2)
    Console.WriteLine(item.i + ":" + item.name);

Console.WriteLine("===================================================");

//var L1 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
//var L2 = new List<int> { 1, 2, 3, 8, 5, 0, 7 };
//var result3 = L1.SequenceEqual(L2);

var custList1 = GetData.GetCustomers();
var custList2 = GetData.GetCustomers();

var result3 = custList1.SequenceEqual(custList2);

Console.WriteLine(result3);
 
