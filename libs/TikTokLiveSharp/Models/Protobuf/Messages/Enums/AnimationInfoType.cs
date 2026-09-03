using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum AnimationInfoType
    {
        NoAnimation = 0,
        EnterRank = 1,
        LeaveRank = 2,
        Rise = 3,
        Fall = 4,
        AfterSettle = 5
    }
}
