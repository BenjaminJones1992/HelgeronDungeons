using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Items
{
    internal class Weapon : GameItem, IEquipableItem
    {
        public bool Equipped { get; set; }
        public int AttackBonus { get; set; }
    }
}
