using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum GroupStatus
    {
        Group_Status_Unknown = 0,
        Group_Status_Waiting = 1,
        Group_Status_Linked = 2
    }
}
