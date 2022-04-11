using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Numbers.Application;

namespace Numbers.ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = new List<int> { 6, 3, -1, 0, 32, 21, -34, 43 };

            var serviceProvider = new ServiceCollection()
                .AddScoped<IArraySearcher, ArraySearcher>(_ => new ArraySearcher(numbers))
                .BuildServiceProvider();

            IArraySearcher arraySearcher;

            try
            {
                arraySearcher = serviceProvider.GetRequiredService<IArraySearcher>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return;
            } 

            var min = arraySearcher.GetMinimum();
            var max = arraySearcher.GetMaximum();

            Console.WriteLine($"Min value = {min}");
            Console.WriteLine($"Max value = {max}");
        }
    }
}
