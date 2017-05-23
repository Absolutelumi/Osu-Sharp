using OsuApi.Model;
using System;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IBestPlayQuery
    {
        Task<Score[]> Result(int limit);

        IBestPlayQuery WithId(string user, UserCredentialType type = UserCredentialType.Auto);
    }

    internal class BestPlayQuery : Query, IBestPlayQuery
    {
        internal BestPlayQuery(string apiKey) : base(apiKey)
        {
        }

        public async Task<Score[]> Result(int limit)
        {
            if (limit < 1 || limit > 10)
                throw new ArgumentOutOfRangeException("Limit must be greater than 0 or less or equal to 10");
            Parameters["limit"] = $"{limit}";
            var jsonResponse = await GetJsonResponse("get_user_best");
            var scores = jsonResponse.Deserialize<Score[]>();
            foreach (Score score in scores)
            {
                var user = await new UserQuery(Parameters["k"]).WithUser(Parameters["u"]).Result();
                score.username = user.username;
                score.user_id = user.user_id;
            }
            return scores;
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