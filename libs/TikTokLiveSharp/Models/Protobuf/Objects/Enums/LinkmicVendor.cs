using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicVendor
    {
        Unknown = 0,
        Agoro = 1,
        Zego = 2,
        Byte = 4,
        Twilio = 8
    }
}
