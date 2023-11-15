// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

//var data = GetData.GetCustomers().Aggregate<Customer, string, string>
//    ("the deserve discounts : ", (s, e) =>
//    {
//        var discount = e.spendAverage * 0.5m;
//        s = s + $" {e.name} : {discount} ,";
//        return s;
//    }, o => o.Replace(":", "->").Substring(0, o.Length - 2));

//Console.WriteLine(data);

//List<int> list = new List<int>();
var list = new List<CustomerCategory>(); //GetData.GetCategories();
var reslut = list.DefaultIfEmpty(new CustomerCategory() { Id = 0 , Name = "N" });

foreach (var item in reslut)
{ 
   Console.WriteLine(item.Name);
}

