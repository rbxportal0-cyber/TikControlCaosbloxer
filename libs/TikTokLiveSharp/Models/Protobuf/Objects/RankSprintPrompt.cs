using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class RankSprintPrompt : AProtoBase
    {
        [ProtoMember(1)]
        public long Countdown { get; }

        [ProtoMember(2)]
        public long Duration { get; }

        [ProtoMember(3)]
        public Text Content { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string BackgroundColor { get; }

        [ProtoMember(5)]
        public long GapScore { get; }

        [ProtoMember(6)]
        public long OwnerRankIdx { get; }
    }
}