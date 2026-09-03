using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SubscribeType
    {
        SubscribeType_Once = 0,
        SubscribeType_Auto = 1,
        SubscribeType_Default = 100
    }
}
