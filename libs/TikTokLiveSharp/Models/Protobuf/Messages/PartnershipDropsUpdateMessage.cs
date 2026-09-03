using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PartnershipDropsUpdateMessage : AProtoBase
    {
        [System.Serializable]
        public enum ChangeMode
        {
            Change_Mode_Show = 0,
            Change_Mode_Update = 1,
            Change_Mode_Close = 2
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ChangeMode Change_Mode { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string DropsId { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string TaskId { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string EventId { get; } = string.Empty;

        [ProtoMember(6)]
        public long AnchorUid { get; }
    }
}
