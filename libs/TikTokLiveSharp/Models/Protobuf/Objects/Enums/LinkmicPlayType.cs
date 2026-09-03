using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkmicPlayType
    {
        PlayType_Invite = 0,
        PlayType_Apply = 1,
        PlayType_Reserve = 2
    }
}
