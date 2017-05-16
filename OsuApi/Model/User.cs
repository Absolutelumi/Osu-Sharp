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
        private double accuracy;

        [DataMember]
        private int count_rank_a;

        [DataMember]
        private int count_rank_s;

        [DataMember]
        private int count_rank_ss;

        [DataMember]
        private int count100;

        [DataMember]
        private int count300;

        [DataMember]
        private int count50;

        [DataMember]
        private string country;

        [DataMember]
        private double level;

        [DataMember]
        private int playcount;

        [DataMember]
        private int pp_country_rank;

        [DataMember]
        private int pp_rank;

        [DataMember]
        private double pp_raw;

        [DataMember]
        private long ranked_score;

        [DataMember]
        private long total_score;

        [DataMember]
        private string user_id;

        [DataMember]
        private string username;

#pragma warning restore 0649

        #endregion Json Fields
    }
}