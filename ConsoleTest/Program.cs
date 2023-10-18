// See https://aka.ms/new-console-template for more information


using System.Linq;

List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6 , 7, 8 , 9 , 10 };
List<string> stringList = new List<string>
             { "ahmed mohamady", "mohamed ahmed", "mo salah", "sayd ahmed" };

//Enumerable.Where()

//var result = myList.Where(l => l > 5);

var result = from l in myList
             where l > 5
             select l;

foreach (var item in result)
{ 
   Console.WriteLine(item);
}