using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Tavern
    {
        private string Booze;
        public string Name { get; set; }
        public string LodgingAvailable { get; set; }
        public string Location { get; set; }
        public List<Booze> Boozes { get; set; } = new List<Booze>();

    }
}