using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum DisplayStyle
    {
        DisplayStyleNormal = 0,
        DisplayStyleStay = 1,
        DisplayStyleChat = 2
    }
}
