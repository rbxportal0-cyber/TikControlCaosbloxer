using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GiftIMPriorityType
    {
        System = 0,
        Self_Sent = 1,
        Valuable_Gift = 2,
        Common_Gift = 3
    }
}
