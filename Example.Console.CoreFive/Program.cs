using System;
using System.Diagnostics;

using StandardLibrary;

namespace Example.Console.CoreFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotnetCore = new ExampleClass();

            dotnetCore.Log("From dotnet Core 5.0 standard library reference.");
        }
    }
}
