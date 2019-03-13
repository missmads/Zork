using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    public enum Directions
    {
        North,
        South,
        East,
        West
    }

    class Area
    {
        //what other areas are connected

        //Area north;
        //Area south;
        //...
        //kinda ugly

        //Area[] neighbors; //we don't have info on directions and needs to be exact size of neighbors (also cannot change)

        //List<Area> neighbors = new List<Area>(); //we don't have info on directions

        Dictionary<Directions, Area> neighbors = new Dictionary<Directions, Area>();
        string name;
        string description;
        List<Item> items = new List<Item>();

        public Area(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void ConnectArea(Directions direction, Area other)
        {
            neighbors.Add(direction, other);
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void PrintDescription()
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            if (items.Count != 0)
            {
                Console.Write("On the floor there is: ");
                foreach(Item i in items)
                {
                    Console.Write(i.name + " ");
                }
                Console.WriteLine();
            }
        }
    }

    
}
