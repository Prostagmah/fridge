using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            Console.WriteLine("Какую еду вы хотите положить в холодильник?");
            string f = Console.ReadLine();
            fridge.Food = f;
            fridge.Time = 1;
            fridge.Freezing();
            Console.ReadKey();
        }
    }
}
