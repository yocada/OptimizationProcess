using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OptimizationProcess
{
    internal class Data
    {
        List<string> items;
        List<ItemSale> itemSales;
        Dictionary<string, int> itemStock;
        List<ItemPBI> itemPBI;

        public Data()
        {
            items = new List<string>();
            itemSales = new List<ItemSale>();
            itemStock = new Dictionary<string, int>();
            itemPBI = new List<ItemPBI>();
        }

        public void simulateData()
        {
            createItems();
            simulateInitialStock();
            simulateItemSales();
        }

        public List<ItemSale>.Enumerator getSales()
        {

            return itemSales.GetEnumerator();
        }

        public void insertItemPBI(string item,double price, int stock)
        {
            itemPBI.Add(new ItemPBI(item, price, stock));
        }

        public int getItemStock(string item)
        {
            Thread.Sleep(5000);
            
            return itemStock[item];
        }

        private void createItems()
        {
            for (int i = 0; i < 10; i++)
            {
                var itemId = "I" + (1000 + i);
                items.Add(itemId);
            }
        }

        private void simulateInitialStock()
        {
            var rndGenerator = new Random();
            foreach (var item in items) 
            {
                var stock = rndGenerator.Next(1000, 2000);
                itemStock.Add(item, stock);
            }
        }

        private void simulateItemSales()
        {
            var rndGenerator = new Random();
            for (int i = 0; i < 100 ; i++) 
            {
                var index = rndGenerator.Next(rndGenerator.Next(items.Count));
                var price = rndGenerator.NextDouble() * 1000;

                var itemId = items[index];

                itemSales.Add(new ItemSale(itemId, price));

                var actualStock = itemStock[itemId];
                itemStock[itemId] = actualStock - 1;
            }
        }
    }
}
