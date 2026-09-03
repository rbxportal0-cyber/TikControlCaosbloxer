using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum DiscordExpiredSubscriberActionType
    {
        DiscordExpiredSubscriberActionTypeNoAction = 0,
        DiscordExpiredSubscriberActionTypeRemoveRole7Days = 1,
        DiscordExpiredSubscriberActionTypeRemoveRole24Hours = 2,
        DiscordExpiredSubscriberActionTypeKickRole7Days = 3,
        DiscordExpiredSubscriberActionTypeKickRole24Hours = 4
    }
}
