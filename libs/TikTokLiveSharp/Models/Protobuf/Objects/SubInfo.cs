using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string UserId { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string AnchorId { get; } = string.Empty;

        [ProtoMember(3)]
        public long SubStartTime { get; }

        [ProtoMember(4)]
        public long SubEndTime { get; }

        [ProtoMember(5)]
        public long NextRenewTime { get; }

        [ProtoMember(6)]
        public int SubscribedMonth { get; }

        [ProtoMember(7)]
        public bool IsSubscribing { get; }

        [ProtoMember(8)]
        public SubLevel SubLevel { get; }

        [ProtoMember(9)]
        public SubscribingStatus Status { get; }

        [ProtoMember(10)]
        public bool SubInfoNotFound { get; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string SKUName { get; } = string.Empty;

        [ProtoMember(12)]
        public PayChannel PayChannel { get; }

        [ProtoMember(13)]
        public GraceInfo GraceInfo { get; }

        [ProtoMember(14)]
        public SubStatisticsData StatisticsInfo { get; }

        [ProtoMember(15)]
        public int SubscribedDays { get; }

        [ProtoMember(16)]
        public PriceChangeInfo PriceChangeInfo { get; }
    }
}
