using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Hashtag : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;

        [ProtoMember(3)]
        public Image Image { get; }

        [ProtoMember(4)]
        public HashtagNamespace Namespace { get; }
    }
}
