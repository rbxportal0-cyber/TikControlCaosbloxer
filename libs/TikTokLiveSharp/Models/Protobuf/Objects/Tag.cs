using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Tag : AProtoBase
    {
        [ProtoMember(1)]
        public int TagType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string TagValue { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string TagText { get; } = string.Empty;
    }
}
