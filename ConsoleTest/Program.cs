// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

var r = Enumerable.Range(1, 1000);

var e = Enumerable.Empty<Customer>();

var rep = Enumerable.Repeat(100, 4);

var cust = GetData.GetCustomers().FirstOrDefault();
var rep2 = Enumerable.Repeat(cust, 4);

//====================================

List<string> names = new List<string>() 
{ "Ahmed Moahamdy", "Mohamed Salah", "alaa khaled"};

var sm = names.SelectMany(element => element.Split(' '));

foreach (var name in sm)
    Console.WriteLine(name);

var smq = from n in names
          from ns in n.Split(" ")
          select ns;

foreach (var name in smq)
    Console.WriteLine(name);
