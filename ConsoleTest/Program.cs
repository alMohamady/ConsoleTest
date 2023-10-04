// See https://aka.ms/new-console-template for more information


using ConsoleTest.Extentions;
using SeedData;
using SeedData.Models;

bool checkCustoemr (Customer  customer)
{
    if (customer != null && customer.age > 30 && customer.isActive)
        return true; 
    else 
        return false;
}


var custList = GetData.GetCustomers().getCustomers(c => c.age > 30 && c.isActive);

foreach (var cust in custList)
{ 
  Console.WriteLine($" name {cust.name}, age {cust.age} ");
}
