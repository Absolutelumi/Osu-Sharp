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
        public int MaxCombo => max_combo;
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
        private int approved;

        [DataMember]
        private string approved_date;

        [DataMember]
        private string artist;

        [DataMember]
        private string beatmap_id;

        [DataMember]
        private string beatmapset_id;

        [DataMember]
        private double bpm;

        [DataMember]
        private string creator;

        [DataMember]
        private double diff_approach;

        [DataMember]
        private double diff_drain;

        [DataMember]
        private double diff_overall;

        [DataMember]
        private double diff_size;

        [DataMember]
        private double difficultyrating;

        [DataMember]
        private int favorite_count;

        [DataMember]
        private string file_md5;

        [DataMember]
        private int genre_id;

        [DataMember]
        private int hit_length;

        [DataMember]
        private int language_id;

        [DataMember]
        private string last_update;

        [DataMember]
        private int max_combo;

        [DataMember]
        private int mode;

        [DataMember]
        private int passcount;

        [DataMember]
        private int playcount;

        [DataMember]
        private string source;

        [DataMember]
        private string tags;

        [DataMember]
        private string title;

        [DataMember]
        private int total_length;

        [DataMember]
        private string version;

#pragma warning restore 0649

        #endregion Json Fields
    }
}