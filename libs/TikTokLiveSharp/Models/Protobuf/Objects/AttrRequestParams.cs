using System.ComponentModel;
using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class AttrRequestParams : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string AttrTypes { get; } = string.Empty;
    }
}
