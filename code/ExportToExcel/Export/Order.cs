using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string Item { get; set; } = string.Empty;
        public int Units { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string SalesAssociate { get; set; } = string.Empty;
        public bool Delivered { get; set; }
    }
}
