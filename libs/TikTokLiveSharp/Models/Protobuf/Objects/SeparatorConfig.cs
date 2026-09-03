using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SeparatorConfig : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Color { get; } = string.Empty;
    }
}
