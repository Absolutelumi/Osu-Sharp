using OsuApi.Queries;

namespace OsuApi
{
    public class Api
    {
        private string ApiKey;

        public IBeatmapSetQuery GetBeatmapSet => new BeatmapQuery(ApiKey);
        public IScoreSpecificQuery GetScores => new ScoreQuery(ApiKey);
        public IBeatmapSpecificQuery GetSpecificBeatmap => new BeatmapQuery(ApiKey);
        public IUserSpecificQuery GetUser => new UserQuery(ApiKey);
        public IBestPlayQuery GetBestPlay => new BestPlayQuery(ApiKey);

        public Api(string apiKey) => ApiKey = apiKey;
    }
}