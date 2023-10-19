// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

//var elemnt = GetData.GetCustomers().ElementAtOrDefault(700);

//var single = GetData.GetCustomers().SingleOrDefault(x => x.id == 101);

//var count = GetData.GetCustomers().Count(x => x.age > 30);

var max = GetData.GetCustomers().Max(x => x.age); //min
var maxCustomer = GetData.GetCustomers().Max(); // min 

//if(maxCustomer != null)
//Console.WriteLine(maxCustomer.name);  

var avrage = GetData.GetCustomers().Average(x => x.spendAverage);
var sum = GetData.GetCustomers().Sum(x => x.spendAverage);

//if (single != null)
//    Console.WriteLine(single.name);
//else
//    Console.WriteLine("No here");