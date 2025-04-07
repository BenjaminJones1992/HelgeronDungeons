using HelgeronDungeons.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelgeronDungeons.Character
{
    class CharacterPlayable : BaseCharacter
    {
        public int Level { get; set; }
        public int ExperiencePts {  get; set; }
        public string Vocation {  get; set; } // Unlock specialisation vocations through playing the base class i.e. Fighter

        public List<GameItem> Inventory { get; set; } = [];


    }
}
