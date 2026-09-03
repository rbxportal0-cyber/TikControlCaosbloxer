using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class HourlyRankSlidePage : AProtoBase
    {
        [ProtoMember(1)]
        public long Duration { get; }

        [ProtoMember(2)]
        public Text Content { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string BackgroundColor { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string SchemeLink { get; } = string.Empty;
    }
}
