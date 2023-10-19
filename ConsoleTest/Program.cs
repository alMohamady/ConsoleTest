// See https://aka.ms/new-console-template for more information


using System.Linq;

List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6 , 7, 8 , 9 , 10 };
List<string> stringList = new List<string>
             { "ahmed mohamady", "mohamed ahmed", "mo salah", "sayd ahmed" };


var names = stringList.Where(x => x.Contains("ahmed"));

//foreach (var name in names)
//{
//    Console.WriteLine(name);  
//}

stringList.Remove("mohamed ahmed");
stringList.AddRange(new string[] { "saeed salah", "ahmed morad", "ahmed ahmed" });

foreach (var name in names)
{
    Console.WriteLine(name);
}
