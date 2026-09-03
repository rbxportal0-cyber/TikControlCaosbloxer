using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Perk : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Title { get; } = string.Empty;
    }
}
