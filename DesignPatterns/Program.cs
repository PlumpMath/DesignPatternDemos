using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractFactoryDemo = new AbstractFactoryClient();
            abstractFactoryDemo.ExecuteDemo();

            Console.ReadKey();
        }
    }
}
