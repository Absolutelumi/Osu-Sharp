using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class MultiplayerMatch
    {
        [DataMember]
        internal Match[] matches;

        [DataMember]
        internal Game[] games;
    }
}
