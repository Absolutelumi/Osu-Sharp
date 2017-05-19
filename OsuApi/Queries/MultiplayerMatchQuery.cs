using OsuApi.Model;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IMultiplayerMatchQuery
    {
        Task<MultiplayerMatch> Result();

        IMultiplayerMatchQuery WithId(string Id); 
    }

    internal class MultiplayerMatchQuery : Query, IMultiplayerMatchQuery
    {
        internal MultiplayerMatchQuery(string apiKey) : base(apiKey)
        {
        }

        public async Task<MultiplayerMatch> Result()
        {
            var jsonResponse = await GetJsonResponse("get_match");
            return jsonResponse.Deserialize<MultiplayerMatch>();
        }

        public IMultiplayerMatchQuery WithId(string Id)
        {
            Parameters["mp"] = Id;
            return this;
        }
    }
}
