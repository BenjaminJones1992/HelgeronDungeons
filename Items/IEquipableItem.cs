using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Items
{
    internal interface IEquipableItem : IGameItem
    {
        bool Equipped { get; set; }
    }
}
