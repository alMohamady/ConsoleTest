using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Extentions
{
    public static class Filter
    {
        public static List<Customer> getByName(this List<Customer> _list, string name)
        { 
            List<Customer> ahmeds = new List<Customer>();
            foreach (var item in _list)
            {
                if (item.name.ToLower().Contains(name))
                {
                    ahmeds.Add(item);
                }
            }
            return ahmeds;
        }
    }
}
