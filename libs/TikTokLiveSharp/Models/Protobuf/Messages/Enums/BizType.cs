using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Enums
{
    [ProtoContract]
    [System.Serializable]
    public enum BizType
    {
        Default = 0,
        Rethink_Chat = 1,
        Rethink_QA = 2,
        WarningTag_CurrentRoom = 3,
        WarningTag_CoHostRoom = 4,
        AGS_AtRiskOfUnableToComment = 5,
        PerceptionCenter = 6
    }
}
