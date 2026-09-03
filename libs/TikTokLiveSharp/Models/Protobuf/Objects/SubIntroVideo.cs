using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubIntroVideo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string ItemId { get; } = string.Empty;

        [ProtoMember(2)]
        public Image Cover { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string PlayUrl { get; } = string.Empty;

        [ProtoMember(4)]
        public long Duration { get; }

        [ProtoMember(5)]
        public User Creator { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Description { get; } = string.Empty;
    }
}
