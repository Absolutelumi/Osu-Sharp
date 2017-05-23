using System;
using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class Score
    {
        public double Accuracy => CalculateAccuracy();
        public int Combo => maxcombo;
        public DateTime Date => DateTime.Parse(date);
        public bool FullCombo => perfect == 1;
        public Mods Mods => enabled_mods.ToMods();
        public int NumberOf100s => count100;
        public int NumberOf300s => count300;
        public int NumberOf50s => count50;
        public int NumberOfGekis => countgeki;
        public int NumberOfKatus => countkatu;
        public int NumberOfMisses => countmiss;
        public double PP => pp;
        public Rank Rank => (Rank)Enum.Parse(typeof(Rank), rank);
        public long TotalScore => score;
        public string UserId => user_id;
        public string Username => username;
        public string BeatmapId => beatmap_id;

        private double CalculateAccuracy()
        {
            int totalPossibleScore = 300 * (count300 + count100 + count50 + countmiss);
            int acquiredScore = 300 * count300 + 100 * count100 + 50 * count50;
            return (double)acquiredScore / totalPossibleScore;
        }

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        internal int count100;

        [DataMember]
        internal int count300;

        [DataMember]
        internal int count50;

        [DataMember]
        internal int countgeki;

        [DataMember]
        internal int countkatu;

        [DataMember]
        internal int countmiss;

        [DataMember]
        internal string date;

        [DataMember]
        internal int enabled_mods;

        [DataMember]
        internal int maxcombo;

        [DataMember]
        internal int perfect;

        [DataMember]
        internal double pp;

        [DataMember]
        internal string rank;

        [DataMember]
        internal long score;

        [DataMember]
        internal string user_id;

        [DataMember]
        internal string username;

        [DataMember]
        internal string beatmap_id;

#pragma warning restore 0649

        #endregion Json Fields
    }
}