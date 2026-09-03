using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftPanelOperation : AProtoBase
    {
        [ProtoMember(1)]
        public Image LeftImage { get; }

        [ProtoMember(2)]
        public Image RightImage { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string TitleColor { get; } = string.Empty;

        [ProtoMember(5)]
        public long TitleSize { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string SchemeUrl { get; } = string.Empty;

        [ProtoMember(7)]
        [DefaultValue("")]
        public string EventName { get; } = string.Empty;
    }
}
