using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class RankEntrance : AProtoBase
    {
        [ProtoMember(1)]
        public RankViewType RankType { get; }

        [ProtoMember(2)]
        public long Countdown { get; }

        [ProtoMember(3)]
        public Text DefaultContent { get; }

        [ProtoMember(4)]
        public RollCfg RollConfig { get; }

        [ProtoMember(5)]
        public bool BlockMessage { get; }

        [ProtoMember(6)]
        public long OwnerRankIdx { get; }

        [ProtoMember(7)]
        public bool OwnerOnRank { get; }

        [ProtoMember(8)]
        public RankViewType RelatedTabRankType { get; }

        [ProtoMember(9)]
        public EntranceGroupType RequestFirstShowType { get; }
    }
}