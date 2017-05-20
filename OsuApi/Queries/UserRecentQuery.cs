using OsuApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IUserRecentQuery
    {
        Task<Score[]> GetUserRecent(int limit = 50);

        IUserRecentQuery WithMode(Mode mode);
    }

    public interface IUserRecentSpecificQuery
    {
        IUserRecentQuery WithUser(string user, UserCredentialType type = UserCredentialType.Auto);
    }

    internal class UserRecentQuery : Query, IUserRecentQuery, IUserRecentSpecificQuery
    {
        internal UserRecentQuery(string apikey) : base(apikey)
        {
        }

        public async Task<Score[]> GetUserRecent(int limit = 50)
        {
            if (limit < 1 || limit > 50)
                throw new ArgumentOutOfRangeException("Limit must be greater than 1 or equal to or less than 50");
            var jsonResponse = await GetJsonResponse("get_user_recent");
            Parameters["limit"] = $"{limit}"; 
            return jsonResponse.Deserialize<Score[]>();
        }

        public IUserRecentQuery WithUser(string user, UserCredentialType type = UserCredentialType.Auto)
        {
            Parameters["u"] = user;
            if (type != UserCredentialType.Auto)
                Parameters["type"] = type == UserCredentialType.Username ? "string" : "id";
            return this;
        }

        public IUserRecentQuery WithMode(Mode mode)
        {
            Parameters["m"] = $"{(int)mode}";
            return this; 
        }
    }
}
