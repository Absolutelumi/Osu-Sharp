using System;
using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class MultiplayerMatch
    {


        #region Json Fields

#pragma warning disable 0649

        public class match
        {
            [DataMember]
            internal string match_id;

            [DataMember]
            internal string name;

            [DataMember]
            internal string start_time;

            [IgnoreDataMember]
            internal string end_time; 
        }

        public class games
        {
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

            public class scores
            {
                [DataMember]
                internal int slot;

                [DataMember]
                internal int team;

                [DataMember]
                internal string user_id;

                [DataMember]
                internal long score;

                [DataMember]
                internal int maxcombo;

                [IgnoreDataMember]
                internal int rank;

                [DataMember]
                internal int count50;

                [DataMember]
                internal int count100;

                [DataMember]
                internal int count300;

                [DataMember]
                internal int countmiss;

                [DataMember]
                internal int countgeki;

                [DataMember]
                internal int countkatu;

                [DataMember]
                internal int perfect;

                [DataMember]
                internal int pass; 
            }
        }

#pragma warning restore 0649

        #endregion
    }
}
