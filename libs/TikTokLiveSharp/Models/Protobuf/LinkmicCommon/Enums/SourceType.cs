using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SourceType
    {
        Source_Type_Unknown = 0,
        Source_Type_Friend_List = 1,
        Source_Type_Recommend_List = 2,
        Source_Type_Recent = 3,
        Source_Type_Other_Follow = 4,
        Source_Type_Quick_Pair = 5,
        Source_Type_Activity = 6,
        Source_Type_Quick_Recommend = 7,
        Source_Type_Official_Channel = 8,
        Source_Type_Best_Teammate = 9,
        Source_Type_Rerservation = 10,
        Source_Type_Pairing = 11,
        Source_Type_Pairing_On_Reservation = 12,
        Source_Type_Topic_Quick_Pair = 13,
        Source_Type_Topic_Quick_Recommend = 14,
        Source_Type_Weekly_Rank = 20,
        Source_Type_Hourly_Rank = 21,
        Source_Type_Weekly_Rising = 23,
        Source_Type_Weekly_Rookie = 24,
        Source_Type_Connection_List = 25,
        Source_Type_Daily_Rank = 26,
        Source_Type_Daily_Rank_Hall_Of_Fame = 27,
        Source_Type_Reservation_Bubble = 28,
        Source_Type_Pairing_Bubble = 29,
        Source_Type_League_Phase_One = 30,
        Source_Type_League_Phase_Two = 31,
        Source_Type_League_Phase_Three = 32,
        Source_Type_Daily_Rookie = 33,
        Source_Type_May_Know_List = 34,
        Source_Type_Banner = 35
    }
}
