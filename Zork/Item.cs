using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Item
    {
        public string description;
        public string name;
        public float weight;

        public Item(string name, string description, float weight)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
        }
    }
}
