using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    internal abstract class Query
    {
        protected Dictionary<string, string> Parameters;

        protected Query(string apiKey)
        {
            Parameters = new Dictionary<string, string>
            {
                { "k", apiKey }
            };
        }

        protected async Task<string> GetJsonResponse(string endpoint)
        {
            var queryString = string.Join("&", Parameters.Select(pair => $"{pair.Key}={pair.Value}"));
            var request = WebRequest.CreateHttp($"https://osu.ppy.sh/api/{endpoint}?{queryString}");
            var response = await request.GetResponseAsync();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}