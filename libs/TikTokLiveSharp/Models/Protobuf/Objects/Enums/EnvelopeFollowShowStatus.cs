using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum EnvelopeFollowShowStatus
    {
        EnvelopeFollowShowUnknown = 0,
        EnvelopeFollowShow = 1,
        EnvelopeFollowNotShow = 2
    }
}
