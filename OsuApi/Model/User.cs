using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class User
    {
        public double Accuracy => accuracy;
        public string Country => country;
        public int CountryRank => pp_country_rank;
        public double Level => level;
        public int PlayCount => playcount;
        public double PP => pp_raw;
        public int Rank => pp_rank;
        public long RankedScore => ranked_score;
        public int Total100s => count100;
        public int Total300s => count300;
        public int Total50s => count50;
        public int TotalAs => count_rank_a;
        public long TotalScore => total_score;
        public int TotalSs => count_rank_s;
        public int TotalSSs => count_rank_ss;
        public string UserID => user_id;
        public string Username => username;

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        internal double accuracy;

        [DataMember]
        internal int count_rank_a;

        [DataMember]
        internal int count_rank_s;

        [DataMember]
        internal int count_rank_ss;

        [DataMember]
        internal int count100;

        [DataMember]
        internal int count300;

        [DataMember]
        internal int count50;

        [DataMember]
        internal string country;

        [DataMember]
        internal double level;

        [DataMember]
        internal int playcount;

        [DataMember]
        internal int pp_country_rank;

        [DataMember]
        internal int pp_rank;

        [DataMember]
        internal double pp_raw;

        [DataMember]
        internal long ranked_score;

        [DataMember]
        internal long total_score;

        [DataMember]
        internal string user_id;

        [DataMember]
        internal string username;

#pragma warning restore 0649

        #endregion Json Fields
    }
}