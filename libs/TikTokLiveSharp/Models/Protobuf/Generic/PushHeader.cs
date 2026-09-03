using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    [ProtoContract]
    public partial class PushHeader : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; set; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Value { get; set; } = string.Empty;
    }
}
