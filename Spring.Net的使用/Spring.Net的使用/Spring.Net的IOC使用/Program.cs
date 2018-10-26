using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net的IOC使用
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            Person lister = (Person)ctx.GetObject("Person");

            Console.WriteLine(lister.SayHello());
            Console.ReadKey();
        }
    }
}
