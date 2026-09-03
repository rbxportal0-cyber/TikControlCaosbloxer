using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class RankTabInfo : AProtoBase
    {
        [ProtoMember(1)]
        public RankViewType RankType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; }

        [ProtoMember(3)]
        public Text TitleText { get; }

        [ProtoMember(4)]
        public long ListLynxType { get; }
    }
}