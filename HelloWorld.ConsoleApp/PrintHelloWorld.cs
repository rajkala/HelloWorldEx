using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.ConsoleApp.Services;

namespace HelloWorld.ConsoleApp
{
    public class PrintHelloWorld
    {
        SayHelloworldService services;
        public PrintHelloWorld()
        {
            services = new SayHelloworldService();
        }
        public async void Print()
        {
            Console.WriteLine("Calling api");
            string output = "";
                 output = await services.Get();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
