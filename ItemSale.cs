using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationProcess
{
    internal class ItemSale
    {
        public string item { get; set; }
        public double price { get; set; }

        public ItemSale(string item, double price)
        {
            this.item = item;
            this.price = price;
        }
    }
}
