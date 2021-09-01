using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StandardLibrary;

namespace Example.Console.NetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotnetFramework = new ExampleClass();

            dotnetFramework.Log("From .Net Framework 4.7.2 standard library reference.");
        }
    }
}
