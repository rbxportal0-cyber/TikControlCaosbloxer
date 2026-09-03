using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum AuditStatus
    {
        AuditStatusUnknown = 0,
        AuditStatusPass = 1,
        AuditStatusFailed = 2,
        AuditStatusReviewing = 3,
        AuditStatusForbidden = 4
    }
}
