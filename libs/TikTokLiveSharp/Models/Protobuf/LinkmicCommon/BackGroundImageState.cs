using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class BackGroundImageState : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string StickerId { get; } = string.Empty;
    }
}
