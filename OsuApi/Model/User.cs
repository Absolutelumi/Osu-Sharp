namespace OsuApi.Model
{
    public class User
    {
        public double Accuracy { get { return accuracy; } }
        public string Country { get { return country; } }
        public int CountryRank { get { return pp_country_rank; } }
        public double Level { get { return level; } }
        public int PlayCount { get { return playcount; } }
        public int Rank { get { return pp_rank; } }
        public long RankedScore { get { return ranked_score; } }
        public double RawPP { get { return pp_raw; } }
        public int Total100s { get { return count100; } }
        public int Total300s { get { return count300; } }
        public int Total50s { get { return count50; } }
        public int TotalAs { get { return count_rank_a; } }
        public long TotalScore { get { return total_score; } }
        public int TotalSs { get { return count_rank_s; } }
        public int TotalSSs { get { return count_rank_ss; } }
        public string UserID { get { return user_id; } }
        public string Username { get { return username; } }

        #region Json Fields

        public double accuracy;
        public int count_rank_a;
        public int count_rank_s;
        public int count_rank_ss;
        public int count100;
        public int count300;
        public int count50;
        public string country;
        public double level;
        public int playcount;
        public int pp_country_rank;
        public int pp_rank;
        public double pp_raw;
        public long ranked_score;
        public long total_score;
        public string user_id;
        public string username;

        #endregion Json Fields
    }
}