using System;

using StandardLibrary.Interfaces;

namespace StandardLibrary
{
    public class ExampleClass : IExample
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
