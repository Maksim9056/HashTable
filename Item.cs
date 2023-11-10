using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Item<T>
    {
        public List<T> Nodes { get; set; }

        public Item(int index)
        {
            Nodes = new List<T>();
        }
    }
}
