using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class HourlyRankEntrance : AProtoBase
    {
        [ProtoMember(1)]
        public bool ShowEntrance { get; }

        [ProtoMember(2)]
        public List<HourlyRankSlidePage> SlidesList { get; } = new List<HourlyRankSlidePage>();

        [ProtoMember(3)]
        public long Countdown { get; }

        [ProtoMember(4)]
        public Text DefaultContent { get; }

        [ProtoMember(5)]
        public HourlyRankSprintPrompt SprintPrompt { get; }

        [ProtoMember(6)]
        public RankViewType RankType { get; }

        [ProtoMember(7)]
        public bool AnchorOnList { get; }

        [ProtoMember(8)]
        public long RollDuration { get; }

        [ProtoMember(9)]
        public bool BlockMessage { get; }

        [ProtoMember(10)]
        public bool ShowEntranceAnimation { get; }
    }
}
