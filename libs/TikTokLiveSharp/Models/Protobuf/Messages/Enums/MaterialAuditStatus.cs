using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum MaterialAuditStatus
    {
        NotReviewed = 0,
        UnderReview = 1,
        ReviewPass = 2,
        ReviewRejected = 3,
        ReviewAbandon = 4
    }
}
