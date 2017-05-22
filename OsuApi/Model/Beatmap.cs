using System;
using System.Runtime.Serialization;

namespace OsuApi.Model
{
    [DataContract]
    public class Beatmap
    {
        public double ApproachRate => diff_approach;
        public DateTime ApprovalDate => DateTime.Parse(approved_date);
        public string Artist => artist;
        public string BeatmapId => beatmap_id;
        public string Beatmapper => creator;
        public string BeatmapSetId => beatmapset_id;
        public double Bpm => bpm;
        public double CircleSize => diff_size;
        public string Difficulty => version;
        public int DrainLength => hit_length;
        public Genre Genre => (Genre)genre_id;
        public double HealthDrain => diff_drain;
        public Language Language => (Language)language_id;
        public DateTime LastUpdate => DateTime.Parse(last_update);
        public int MaxCombo => max_combo ?? 0;
        public string Md5Hash => file_md5;
        public Mode Mode => (Mode)mode;
        public int NumberOfFavorites => favorite_count;
        public int NumberOfPasses => passcount;
        public int NumberOfPlays => playcount;
        public double OverallDifficulty => diff_overall;
        public string Source => source;
        public double Stars => difficultyrating;
        public Status Status => (Status)approved;
        public string[] Tags => tags.Split(' ');
        public string Title => title;
        public int TotalLength => total_length;

        #region Json Fields

#pragma warning disable 0649

        [DataMember]
        internal int approved;

        [DataMember]
        internal string approved_date;

        [DataMember]
        internal string artist;

        [DataMember]
        internal string beatmap_id;

        [DataMember]
        internal string beatmapset_id;

        [DataMember]
        internal double bpm;

        [DataMember]
        internal string creator;

        [DataMember]
        internal double diff_approach;

        [DataMember]
        internal double diff_drain;

        [DataMember]
        internal double diff_overall;

        [DataMember]
        internal double diff_size;

        [DataMember]
        internal double difficultyrating;

        [DataMember]
        internal int favorite_count;

        [DataMember]
        internal string file_md5;

        [DataMember]
        internal int genre_id;

        [DataMember]
        internal int hit_length;

        [DataMember]
        internal int language_id;

        [DataMember]
        internal string last_update;

        [DataMember]
        internal int? max_combo;

        [DataMember]
        internal int mode;

        [DataMember]
        internal int passcount;

        [DataMember]
        internal int playcount;

        [DataMember]
        internal string source;

        [DataMember]
        internal string tags;

        [DataMember]
        internal string title;

        [DataMember]
        internal int total_length;

        [DataMember]
        internal string version;

#pragma warning restore 0649

        #endregion Json Fields
    }
}