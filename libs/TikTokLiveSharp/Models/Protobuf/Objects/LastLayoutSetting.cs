using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LastLayoutSetting : AProtoBase
    {
        [ProtoMember(1)]
        public long Scene { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LayoutId { get; } = string.Empty;
    }
}
