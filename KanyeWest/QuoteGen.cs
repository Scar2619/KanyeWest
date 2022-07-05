using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteGen
    {
        private HttpClient _client;

        public QuoteGen(HttpClient client)
        {
            _client = client;
        }

        public string Kanye()
        {
            //Creating Kanye West
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            //Creating Ron Swanson
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);

            return ronQuote[0].ToString();
        }
    }
}

