using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.AddProducts();
            Methods.Receipt("2021-06-14");

            Console.ReadLine();
        }
    }
}
