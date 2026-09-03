using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicAudienceStatus
    {
        Audience_Status_Unknown = 0,
        Waiting = 1,
        Linked = 2,
        Finished = 3,
        Waiting_And_Linked = 4
    }
}
