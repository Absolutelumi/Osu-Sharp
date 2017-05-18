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
        None = 0,
        NoFail = 1 << 0,
        Easy = 1 << 1,
        NoVideo = 1 << 2,
        Hidden = 1 << 3,
        HardRock = 1 << 4,
        SuddenDeath = 1 << 5,
        DoubleTime = 1 << 6,
        Relax = 1 << 7,
        HalfTime = 1 << 8,
        Nightcore = 1 << 9,
        Flashlight = 1 << 10,
        Autoplay = 1 << 11,
        SpunOut = 1 << 12,
        AutoPilot = 1 << 13,
        Perfect = 1 << 14,
        Key4 = 1 << 15,
        Key5 = 1 << 16,
        Key6 = 1 << 17,
        Key7 = 1 << 18,
        Key8 = 1 << 19,
        FadeIn = 1 << 20,
        Random = 1 << 21
    }

    public enum Rank
    {
        D,
        C,
        B,
        A,
        S,
        SH,
        SS,
        SX
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