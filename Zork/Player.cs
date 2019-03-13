using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Player
    {
        Area currentArea;
        List<Item> inventory = new List<Item>();
        float carryingCapacity = 10f;
    }
}
