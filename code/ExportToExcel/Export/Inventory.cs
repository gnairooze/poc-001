using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    internal class Inventory
    {
        public int ItemId { get; set; }
        public string Item { get; set; } = string.Empty;
        public int Number { get; set; }
        public double Price { get; set; }
    }
}
