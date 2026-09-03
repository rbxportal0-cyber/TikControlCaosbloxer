using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubRankTabInfo : AProtoBase
    {
        [ProtoMember(1)]
        public RankViewType RankType { get; }

        [ProtoMember(2)]
        public Text TitleText { get; }
    }
}
