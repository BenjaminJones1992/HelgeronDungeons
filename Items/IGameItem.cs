using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Items
{
    interface IGameItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
