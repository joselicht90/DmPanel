using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonsDragons.Models
{

    public class ResponseDTO
    {
        public int Count { get; set; }
        public IList<ItemsDTO> Results { get; set; }
    }

    public class ItemsDTO
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}