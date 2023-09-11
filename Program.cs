using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            data.simulateData();

            Stopwatch timer = new Stopwatch();

            timer.Start();

            var sales = data.getSales();
            while (sales.MoveNext())
            {
                var sale = sales.Current;

                var stock = data.getItemStock(sale.item);

                data.insertItemPBI(sale.item, sale.price, stock);

                Debug.WriteLine("Time elapsed: " + timer.ElapsedMilliseconds / 1000);
            }

            timer.Stop();

            Debug.WriteLine("Total time elapsed: " +  timer.ElapsedMilliseconds / 1000);
        }
    }
}
