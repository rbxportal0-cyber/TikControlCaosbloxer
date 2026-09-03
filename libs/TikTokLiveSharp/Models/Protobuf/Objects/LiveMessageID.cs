using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LiveMessageID : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string PrimaryId { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string MessageScene { get; } = string.Empty;
    }
}
