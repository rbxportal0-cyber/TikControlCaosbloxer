using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum SpotlightReviewStatus
    {
        SpotlightReviewStatusUnknown = 0,
        SpotlightReviewStatusApproved = 1,
        SpotlightReviewStatusUnderReview = 2,
        SpotlightReviewStatusRejected = 3
    }
}
