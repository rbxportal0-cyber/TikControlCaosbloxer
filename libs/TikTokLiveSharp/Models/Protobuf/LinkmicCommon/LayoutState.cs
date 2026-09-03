using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LayoutState : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string LayoutId { get; } = string.Empty;
    }
}
