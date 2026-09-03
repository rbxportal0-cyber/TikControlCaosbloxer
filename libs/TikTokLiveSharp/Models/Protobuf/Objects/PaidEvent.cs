using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PaidEvent : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        [System.Serializable]
        public enum PaidType
        {
            Free = 0,
            Paid = 1
        }
        #endregion

        [ProtoMember(1)]
        public long EventId { get; }

        [ProtoMember(2)]
        public PaidType Paid_Type { get; }
    }
}
