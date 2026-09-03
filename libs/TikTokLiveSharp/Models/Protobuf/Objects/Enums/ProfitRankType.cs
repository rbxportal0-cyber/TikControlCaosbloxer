using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum ProfitRankType
    {
        TypeHourlyRank = 0,
        TypeWeeklyRank = 1,
        TypeHourlyStarRank = 2,
        TypeWeeklyRisingRankActivity = 3,
        TypeWeeklyRisingRank = 4,
        TypeWeeklyRookie = 5,
        TypeECommerceWeekly = 6,
        TypeECommerceDaily = 7,
        TypeDailyRank = 8,
        TypeFirstGiftRank = 9,
        TypeGameRank = 10,
        TypeDailyGame = 11,
        TypeHallOfFameRank = 12,
        Profit_Rank_Type_Daily_Rookie = 14,
        TypeDailyGamePUBG = 20,
        TypeDailyGameMLBB = 21,
        TypeDailyGameFreeFire = 22,
        TypeRankLeague = 13
    }
}
