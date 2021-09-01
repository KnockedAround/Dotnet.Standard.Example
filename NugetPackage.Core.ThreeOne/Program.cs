using System;

using StandardLibrary;

namespace NugetPackage.Core.ThreeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotnetCoreThreeOneNuget = new ExampleClass();

            dotnetCoreThreeOneNuget.Log("From dotnet 3.1 standard library nuget package.");
        }
    }
}
