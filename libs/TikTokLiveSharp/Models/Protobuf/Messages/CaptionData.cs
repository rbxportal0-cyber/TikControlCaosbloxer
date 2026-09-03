using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class CaptionData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string ISOLanguage { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Value { get; } = string.Empty;
    }
}
