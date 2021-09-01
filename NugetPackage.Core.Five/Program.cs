using System;

using StandardLibrary;

namespace NugetPackage.Core.Five
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotnetCoreFiveNuget = new ExampleClass();

            dotnetCoreFiveNuget.Log("From dotnet core 5.0 standard library nuget package.");
        }
    }
}
