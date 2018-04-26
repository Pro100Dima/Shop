using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DAL.Module;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct q = new ServiceProduct();
            List<Grocery> w = q.GenerateShops();
            foreach (Grocery item in w.OrderBy(o => o.Products.Count()))
            {
                item.Info();
            }
            Console.WriteLine("vvedite nazvanie magazina");
            string terp = Console.ReadLine();
            Console.Clear();

            Grocery yt = w.FirstOrDefault(o => o.Name == terp);
            if (yt != null)
            {
                Console.WriteLine("vvedite nomer producta");
                int temp = Int32.Parse(Console.ReadLine());// pereveli string v int
                Product findProd = yt[temp];
                findProd.PrintInfo();
            }

        }
    }
}
