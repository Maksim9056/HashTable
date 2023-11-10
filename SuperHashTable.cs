using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class SuperHashTable
    {
        Hashtable openWith = new Hashtable();
        public SuperHashTable()
        {
        }
        public void Add(Person item)
        {
            if (openWith.ContainsKey(item.Name))
            {
            }
            else
            {
                openWith.Add(item.Name, item);
            }
        }



        /// <summary>
        /// Search
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Search(string name)
        {
            bool value = openWith.ContainsKey(name);
            return value;
        }
    }
}
