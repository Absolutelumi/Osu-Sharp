using OsuApi.Model;
using System;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IScoreQuery
    {
        IScoreQuery PlayedBy(string user, UserCredentialType type = UserCredentialType.Auto);

        Task<Score[]> Results(int limit = 50);

        IScoreQuery WithMode(Mode mode);

        IScoreQuery WithMods(Mods mods);
    }

    public interface IScoreSpecificQuery
    {
        IScoreQuery OnBeatmapWithId(string beatmapId);
    }

    internal class ScoreQuery : Query, IScoreQuery, IScoreSpecificQuery
    {
        internal ScoreQuery(string apiKey) : base(apiKey)
        {
        }

        public IScoreQuery OnBeatmapWithId(string beatmapId)
        {
            Parameters["b"] = beatmapId;
            return this;
        }

        public IScoreQuery PlayedBy(string user, UserCredentialType type = UserCredentialType.Auto)
        {
            Parameters["u"] = user;
            if (type != UserCredentialType.Auto)
            {
                Parameters["type"] = type == UserCredentialType.Username ? "string" : "id";
            }
            return this;
        }

        public async Task<Score[]> Results(int limit = 50)
        {
            if (limit < 1 || limit > 100)
                throw new ArgumentOutOfRangeException("Limit must be between 1 and 100");
            Parameters["limit"] = $"{limit}";
            var jsonResponse = await GetJsonResponse("get_scores");
            return jsonResponse.Deserialize<Score[]>();
        }

        public IScoreQuery WithMode(Mode mode)
        {
            Parameters["m"] = $"{(int)mode}";
            return this;
        }

        public IScoreQuery WithMods(Mods mods)
        {
            Parameters["mods"] = $"{mods.ToInt()}";
            return this;
        }
    }
}