using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TestDemo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Value { get; } = string.Empty;
    }
}
