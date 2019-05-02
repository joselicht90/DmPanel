using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonsDragons.Models
{


    public class Race
    {
        enum Stats
        {
            STR = 0,
            DEX = 1,
            CON = 2,
            WIS = 3,
            INT = 4,
            CHA = 5
        }

        public string _id { get; set; }
        public string Url { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int[] Ability_Bonuses { get; set; }
        public string Alignment { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        public string Size_Description { get; set; }
        public IList<ItemsDTO> Starting_Proficiencies { get; set; }
        public IList<ItemsDTO> Languages { get; set; }
        public string Language_desc { get; set; }
        public IList<ItemsDTO> Traits { get; set; }
        public IList<ItemsDTO> Subraces { get; set; }

        public string GetTraits()
        {
            string traitMessage = "";
            for (int i = 0; i < 6; i++)
            {
                if (Ability_Bonuses[i] != 0)
                    switch (i)
                    {
                        case 0:
                            traitMessage += "STR +" + Ability_Bonuses[i] + ", ";
                            break;
                        case 1:
                            traitMessage += "DEX +" + Ability_Bonuses[i] + ", ";
                            break;
                        case 2:
                            traitMessage += "CON +" + Ability_Bonuses[i] + ", ";
                            break;
                        case 3:
                            traitMessage += "WIS +" + Ability_Bonuses[i] + ", ";
                            break;
                        case 4:
                            traitMessage += "INT +" + Ability_Bonuses[i] + ", ";
                            break;
                        case 5:
                            traitMessage += "CHA +" + Ability_Bonuses[i] + ", ";
                            break;
                    }
            }
            foreach(ItemsDTO item in Traits)
            {
                traitMessage += item.Name + ", ";
            }
            traitMessage = traitMessage.Substring(0, traitMessage.Length - 2) + ".";

            return traitMessage;

        }
    }
}