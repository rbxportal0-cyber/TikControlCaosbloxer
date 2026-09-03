using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BadgeSceneType
    {
        BadgeSceneType_Unknown = 0,
        BadgeSceneType_Admin = 1,
        BadgeSceneType_FirstRecharge = 2,
        BadgeSceneType_Friends = 3,
        BadgeSceneType_Subscriber = 4,
        BadgeSceneType_Activity = 5,
        BadgeSceneType_RankList = 6,
        BadgeSceneType_NewSubscriber = 7,
        BadgeSceneType_UserGrade = 8,
        BadgeSceneType_StateControlledMedia = 9,
        BadgeSceneType_Fans = 10,
        BadgeSceneType_LivePro = 11
    }
}
