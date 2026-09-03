using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum LinkMicUserAdminType
    {
        Undefined_Type = 0,
        Manager_Type = 1,
        Host_Type = 2
    }
}
