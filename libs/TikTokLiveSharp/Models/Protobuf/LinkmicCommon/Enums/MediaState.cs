using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum MediaState
    {
        Media_Undefined = 0,
        Media_Normal = 1,
        Media_Muted = 2,
        Media_Unmute_Occupied = 3,
        Media_Muted_Occupied = 4
    }
}
