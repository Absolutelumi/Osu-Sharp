using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    class MultiplayerScore
    {
        public int Slot => slot;
        public Team Team => (Team)team;
        public string UserId => user_id;
        public long Score => score;
        public int MaxCombo => maxcombo;
        public int Count50 => count50;
        public int Count100 => count100;
        public int Count300 => count300;
        public int CountMiss => countmiss;
        public int CountGeki => countgeki;
        public int CountKatu => countkatu;
        public bool FullCombo => perfect == 1;
        public bool Pass => pass == 1; 

        #region Json Fields

#pragma warning disable 0649

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

#pragma warning disable 0649

        #endregion
    }
}
