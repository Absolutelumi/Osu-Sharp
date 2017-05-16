using System;
using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class Score
    {
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

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        private int count100;

        [DataMember]
        private int count300;

        [DataMember]
        private int count50;

        [DataMember]
        private int countgeki;

        [DataMember]
        private int countkatu;

        [DataMember]
        private int countmiss;

        [DataMember]
        private string date;

        [DataMember]
        private int enabled_mods;

        [DataMember]
        private int maxcombo;

        [DataMember]
        private int perfect;

        [DataMember]
        private double pp;

        [DataMember]
        private string rank;

        [DataMember]
        private long score;

        [DataMember]
        private string user_id;

        [DataMember]
        private string username;

#pragma warning restore 0649

        #endregion Json Fields
    }
}