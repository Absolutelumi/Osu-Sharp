using System.Runtime.Serialization;
using System;

namespace OsuApi.Model
{
    [DataContract]
    class Game
    {
        internal MultiplayerScore[] scores;

        public string MatchId => match_id;
        public DateTime StartTime => DateTime.Parse(start_time);
        public DateTime EndTime => DateTime.Parse(end_time);
        public string BeatmapId => beatmap_id;
        public Mode PlayMode => (Mode)play_mode;
        public ScoringType Scoring => (ScoringType)scoring_type;
        public TeamType TeamVer => (TeamType)team_type;
        public Mods Mods => mods.ToMods(); 

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        internal string match_id;

        [DataMember]
        internal string start_time;

        [DataMember]
        internal string end_time;

        [DataMember]
        internal string beatmap_id;

        [DataMember]
        internal int play_mode;

        [DataMember]
        internal int scoring_type;

        [DataMember]
        internal int team_type;

        [DataMember]
        internal int mods;

#pragma warning restore 0649

        #endregion
    }
}
