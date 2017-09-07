using System;

namespace OsuApi.Model
{
    public enum Genre
    {
        Any = 0,
        Unspecified = 1,
        VideoGame = 2,
        Anime = 3,
        Rock = 4,
        Pop = 5,
        Other = 6,
        Novelty = 7,
        HipHop = 9,
        Electronic = 10
    }

    public enum Language
    {
        Any = 0,
        Other = 1,
        English = 2,
        Japanese = 3,
        Chinese = 4,
        Instrumental = 5,
        Korean = 6,
        French = 7,
        German = 8,
        Swedish = 9,
        Spanish = 10,
        Italian = 11
    }

    public enum Mode
    {
        Osu = 0,
        Taiko = 1,
        CatchTheBeat = 2,
        Mania = 3
    }

    [Flags]
    public enum Mods
    {
        NM = 0,
        NF = 1 << 0,
        EZ = 1 << 1,
        NoVideo = 1 << 2,
        HD = 1 << 3,
        HR = 1 << 4,
        SD = 1 << 5,
        DT = 1 << 6,
        RX = 1 << 7,
        HT = 1 << 8,
        NC = 1 << 9,
        FL = 1 << 10,
        Autoplay = 1 << 11,
        SO = 1 << 12,
        AP = 1 << 13,
        PF = 1 << 14,
        K4 = 1 << 15,
        K5 = 1 << 16,
        K6 = 1 << 17,
        K7 = 1 << 18,
        K8 = 1 << 19,
        FI = 1 << 20,
        Random = 1 << 21
    }

    public enum Rank
    {
        F,
        D,
        C,
        B,
        A,
        S,
        SH,
        SS,
        SX,
        XH
    }

    public enum Status
    {
        Graveyard = -2,
        WorkInProgress = -1,
        Pending = 0,
        Ranked = 1,
        Approved = 2,
        Qualified = 3,
        Loved = 4
    }

    public enum UserCredentialType
    {
        Auto,
        Username,
        UserId
    }

    public enum ScoringType
    {
        Score = 0,
        Accuracy = 1,
        Combo = 2,
        ScoreV2 = 3,
    }

    public enum Team
    {
        None = 0,
        Blue = 1,
        Red = 2
    }

    public enum TeamType
    {
        HeadToHead = 0,
        TagCoOp = 1,
        TeamVs = 2,
        TagTeamVs = 3
    }
}