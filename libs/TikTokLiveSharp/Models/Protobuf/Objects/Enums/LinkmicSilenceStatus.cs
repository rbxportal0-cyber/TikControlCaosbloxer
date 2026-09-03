using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicSilenceStatus
    {
        Unsilence = 0,
        Silence_By_Self = 1,
        Silence_By_Owner = 2
    }
}
