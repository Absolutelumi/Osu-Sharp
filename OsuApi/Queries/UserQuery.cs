using OsuApi.Model;
using System.Linq;
using System.Threading.Tasks;

namespace OsuApi.Queries
{
    public interface IUserQuery
    {
        Task<User> Result();

        IUserQuery WithMode(Mode mode);
    }

    public interface IUserSpecificQuery
    {
        IUserQuery WithUser(string user, UserCredentialType type = UserCredentialType.Auto);
    }

    internal class UserQuery : Query, IUserQuery, IUserSpecificQuery
    {
        internal UserQuery(string apiKey) : base(apiKey)
        {
        }

        public async Task<User> Result()
        {
            var jsonResponse = await GetJsonResponse("get_user");
            return jsonResponse.Deserialize<User[]>().FirstOrDefault();
        }

        public IUserQuery WithMode(Mode mode)
        {
            Parameters["m"] = $"{(int)mode}"; 
            return this;
        }

        public IUserQuery WithUser(string user, UserCredentialType type = UserCredentialType.Auto)
        {
            Parameters["u"] = user;
            if (type != UserCredentialType.Auto)
                Parameters["type"] = type == UserCredentialType.Username ? "string" : "id";
            return this;
        }
    }
}