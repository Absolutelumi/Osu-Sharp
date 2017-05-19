using System.Runtime.Serialization;
using System;

namespace OsuApi.Model
{
    [DataContract]
    class Match
    {
        public string MatchId => match_id;
        public string Name => name;
        public DateTime StartTime => DateTime.Parse(start_time); 

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        internal string match_id;

        [DataMember]
        internal string name;

        [DataMember]
        internal string start_time;

#pragma warning restore 0649

        #endregion
    }
}
