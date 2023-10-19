// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;

//List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6 , 7, 8 , 9 , 10 };
//List<string> stringList = new List<string>
//             { "ahmed mohamady", "mohamed ahmed", "mo salah", "sayd ahmed" };


//var customers = GetData.GetCustomers().Where((x, i) => x.age > 30 && i >= 3).Select(
//       a => new CustomerDto
//       {
//           customerName = a.name,
//           customerPhone = a.telephone,
//       }
//    );

var customers2 = from cust in GetData.GetCustomers()
               select new 
               {
                   cust.name,
                   cust.telephone,
                   _age = cust.age
               }
               into c
               where c._age > 30 
               select c;


foreach (var customer in customers2)
{
    Console.WriteLine(customer.name);
}