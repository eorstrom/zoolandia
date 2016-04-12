using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal larry = new Animal(args[0]);
            larry.name = args[0];
            Console.WriteLine("{0} the Animal!", larry.name);
        }
    }
}

