// See https://aka.ms/new-console-template for more information


using SeedData;
using SeedData.Models;
using System.Linq;
using System.Text.RegularExpressions;

List<string> names = new List<string>()
{ "@hmed" , "Mo&ed", "3alah"  };

//var Result = from n in names
//             select Regex.Replace(n, "[@&3]", "_")
//             into newVal
//             where newVal.ToLower().Contains("m")
//             orderby newVal.Length
//             select newVal;

var Result = from n in names
             let newVal = Regex.Replace(n, "[@&3]", "_")
             where newVal.ToLower().Contains("m")
             orderby newVal.Length , n.Length
             select newVal;

foreach (var name in Result)
    Console.WriteLine(name);



