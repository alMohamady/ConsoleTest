using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public static List<Customer> getCustomers(this List<Customer> _list, Func<Customer, bool> func)
        {
            List<Customer> list = new List<Customer>();
            foreach (var item in _list)
            {
                if (func(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
