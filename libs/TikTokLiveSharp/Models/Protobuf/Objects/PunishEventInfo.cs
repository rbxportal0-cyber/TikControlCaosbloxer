using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PunishEventInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string PunishType { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string PunishReason { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string PunishId { get; } = string.Empty;

        [ProtoMember(4)]
        public long ViolationUid { get; }

        [ProtoMember(5)]
        public PunishTypeId PunishTypeId { get; }

        [ProtoMember(6)]
        public long Duration { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string PunishPerceptionCode { get; } = string.Empty;
    }
}