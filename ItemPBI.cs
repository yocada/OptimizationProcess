using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationProcess
{
    internal class ItemPBI
    {
        public string item { get; set; }
        public double price { get; set; }
        public int stock { get; set; }

        public ItemPBI(string item, double price, int stock)
        {
            this.item = item;
            this.price = price;
            this.stock = stock;
        }
    }
}
