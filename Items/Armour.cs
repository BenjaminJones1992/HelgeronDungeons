using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Items
{
    internal class Armour : GameItem, IEquipableItem
    {
        public bool Equipped { get; set; }
        public int ACBonus { get; set; }
    }
}
