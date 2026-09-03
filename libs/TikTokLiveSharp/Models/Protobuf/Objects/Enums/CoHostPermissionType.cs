using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum CoHostPermissionType
    {
        No_Perm = 0,
        CoHost_Perm = 1,
        MultiHost_Perm = 2
    }
}
