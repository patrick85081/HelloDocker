using System;
using System.Net.WebSockets;
using MyClass;

namespace HelloDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(new SuperClass().GetString());
            
            Console.WriteLine("Hello World!");
        }
    }
}