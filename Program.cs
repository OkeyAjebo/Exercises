using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUM Example");
            Console.WriteLine("********************************");
            var select = InventoryManager.GetInventories().Select(x => x.Price);
            var sum = select.Sum();
            foreach (var item in select)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The Total sum of all Merchandise is #" + sum);
            Console.WriteLine("********************************");


            Console.WriteLine("OrderBy Example");
            Console.WriteLine("********************************");
            var a = InventoryManager.GetInventories().OrderBy(x => x.Id).ThenBy(x => x.EntryDate);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("OrderByDescending Example");
            Console.WriteLine("********************************");
            var b = InventoryManager.GetInventories().OrderByDescending(x => x.Id).ThenBy(x => x.EntryDate);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("TakeWhile");
            Console.WriteLine("********************************");
            var c = InventoryManager.GetInventories().TakeWhile(x => x.Price > 5000);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("SkipWhile Example");
            Console.WriteLine("********************************");
            var d = InventoryManager.GetInventories().SkipWhile(x => x.Price > 5000);
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("Union Example");
            Console.WriteLine("********************************");
            var e = InventoryManager.GetInventories().Union(InventoryManager.FreshInventories(), new CompareInventory());
            foreach (var item in e)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("Concat Example");
            Console.WriteLine("********************************");
            var f = InventoryManager.GetInventories().Concat(InventoryManager.FreshInventories());
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("Distinct Example");
            Console.WriteLine("********************************");
            var g = InventoryManager.GetInventories().Distinct(new CompareInventory());
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("Intersect Example");
            Console.WriteLine("********************************");
            var h = InventoryManager.GetInventories().Intersect(InventoryManager.FreshInventories(), new CompareInventory());
            foreach (var item in h)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.WriteLine("Except Example");
            Console.WriteLine("********************************");
            var i = InventoryManager.GetInventories().Except(InventoryManager.FreshInventories(), new CompareInventory());
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********************************");


            Console.ReadLine();
        }
    }
}
