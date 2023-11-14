// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//var isAllAge = GetData.GetCustomers().All(e => e.name.Contains("ahmed"));
//Console.WriteLine(isAllAge.ToString());


//var isAnyAge = GetData.GetCustomers().Any(e => e.name.Contains("ahmed"));
//Console.WriteLine(isAnyAge.ToString());

var cust = new Customer { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 };

var isContAge = GetData.GetCustomers().Contains(cust, new CustCompar());
Console.WriteLine(isContAge.ToString());

public class CustCompar : IEqualityComparer<Customer>
{
    public bool Equals(Customer? x, Customer? y)
    {
        return x.id == y.id;
    }

    public int GetHashCode([DisallowNull] Customer obj)
    {
        return obj.id.GetHashCode();
    }
}