using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkSilenceStatus
    {
        Status_Unsilence = 0,
        Status_Silence_By_Self = 1,
        Status_Silence_By_Owner = 2
    }
}
