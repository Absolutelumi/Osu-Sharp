using OsuApi.Model;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IBestPlayQuery
    {
        Task<Score> Result();

        IBestPlayQuery WithId(string user, UserCredentialType type = UserCredentialType.Auto); 
    }

    internal class BestPlayQuery : Query, IBestPlayQuery
    {
        internal BestPlayQuery(string apiKey) : base(apiKey)
        {
        }

        public async Task<Score> Result()
        {
            var jsonResponse = await GetJsonResponse("get_user_best");
            return jsonResponse.Deserialize<Score>();
        }

        public IBestPlayQuery WithId(string user, UserCredentialType type = UserCredentialType.Auto)
        {
            Parameters["u"] = user;
            if (type != UserCredentialType.Auto)
            {
                Parameters["type"] = type == UserCredentialType.Username ? "string" : "id";
            }
            return this;
        }
    }
}
