using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Indicator : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Key { get; } = string.Empty;

        [ProtoMember(2)]
        public IndicatorOp Op { get; }
    }
}
