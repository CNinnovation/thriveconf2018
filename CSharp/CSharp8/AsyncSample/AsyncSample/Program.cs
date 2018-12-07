using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncSample
{
    public class Subscriber
    {
        public string Name { get; set; }
    }

    class Program
    {
        static async Task Main()
        {
            await foreach (var name in GetSubscribersAsync())
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        public static async IAsyncEnumerable<string> GetSubscribersAsync()
        {
            string[] names = new[] { "Angela", "Stephanie", "Matthias", "Katharina" };
            foreach (var name in names)
            {
                await Task.Delay(2000);
                yield return name;
            }
        }
    }
}
