using OsuApi.Model;
using System;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IBeatmapQuery
    {
        IBeatmapQuery AllowConvertedBeatmaps(bool allow);

        IBeatmapQuery CreatedBy(string user, UserCredentialType type = UserCredentialType.Auto);

        Task<Beatmap[]> Results(int limit = 500);

        IBeatmapQuery Since(DateTime date);

        IBeatmapQuery WithHash(string hash);

        IBeatmapQuery WithId(string id);

        IBeatmapQuery WithMode(Mode mode);
    }

    public interface IBeatmapSetQuery
    {
        IBeatmapQuery WithSetId(string setId);
    }

    public interface IBeatmapSpecificQuery
    {
        IBeatmapQuery WithId(string id);
    }

    internal class BeatmapQuery : Query, IBeatmapQuery, IBeatmapSetQuery, IBeatmapSpecificQuery
    {
        internal BeatmapQuery(string apiKey) : base(apiKey)
        {
        }

        public IBeatmapQuery AllowConvertedBeatmaps(bool allow)
        {
            Parameters["a"] = allow ? "1" : "0";
            return this;
        }

        public IBeatmapQuery CreatedBy(string user, UserCredentialType type)
        {
            Parameters["u"] = user;
            if (type != UserCredentialType.Auto)
            {
                Parameters["type"] = type == UserCredentialType.Username ? "string" : "id";
            }
            return this;
        }

        public async Task<Beatmap[]> Results(int limit)
        {
            Parameters["limit"] = $"{limit}";
            var jsonResponse = await GetJsonResponse("get_beatmaps");
            return jsonResponse.Deserialize<Beatmap[]>();
        }

        public IBeatmapQuery Since(DateTime date)
        {
            Parameters["since"] = date.ToString("yyyy-MM-dd H:mm:ss");
            return this;
        }

        public IBeatmapQuery WithHash(string hash)
        {
            Parameters["h"] = hash;
            return this;
        }

        public IBeatmapQuery WithId(string id)
        {
            Parameters["b"] = id;
            return this;
        }

        public IBeatmapQuery WithMode(Mode mode)
        {
            Parameters["m"] = $"{(int)mode}";
            return this;
        }

        public IBeatmapQuery WithSetId(string setId)
        {
            Parameters["s"] = setId;
            return this;
        }
    }
}