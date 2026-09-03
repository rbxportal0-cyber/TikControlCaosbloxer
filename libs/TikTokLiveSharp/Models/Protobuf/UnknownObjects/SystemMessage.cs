using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class SystemMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Message { get; } = string.Empty;
    }
}
