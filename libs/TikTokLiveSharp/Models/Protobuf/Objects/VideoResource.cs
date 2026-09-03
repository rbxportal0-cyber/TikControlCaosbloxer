using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class VideoResource : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string VideoTypeName { get; } = string.Empty;

        [ProtoMember(2)]
        public Image VideoUrl { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string VideoMd5 { get; } = string.Empty;
    }
}
