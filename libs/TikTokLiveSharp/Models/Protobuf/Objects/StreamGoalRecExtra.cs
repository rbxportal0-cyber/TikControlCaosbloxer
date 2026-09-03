using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class StreamGoalRecExtra : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string LeadText { get; } = string.Empty;
    }
}
