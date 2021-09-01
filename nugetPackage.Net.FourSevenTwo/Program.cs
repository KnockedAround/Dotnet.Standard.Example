using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StandardLibrary;

namespace nugetPackage.Net.FourSevenTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var netFrameworkFourSevenTwo = new ExampleClass();

            netFrameworkFourSevenTwo.Log("From .Net Framework 4.7.2 standard library nuget package.");
        }
    }
}
