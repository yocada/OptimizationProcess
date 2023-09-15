using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationProcess
{
    internal class Optimizer
    {
        public static int optimizeGetItemStock(Dictionary<string, int> results, string item, Data data)
        {
            if (results.ContainsKey(item))
            {
                return results[item];
            }
            else
            {
                var stock = data.getItemStock(item);
                results.Add(item, stock);
                return stock;
            }
        }
    }
}
