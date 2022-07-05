using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            var newQuote = new QuoteGen(client);

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Kanye West: {newQuote.Kanye()}");
                Console.WriteLine($"Ron Swanson: {newQuote.RonSwanson()}");
            }

        }
    }
}

