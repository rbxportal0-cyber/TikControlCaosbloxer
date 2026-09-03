using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class DSLConfig : AProtoBase
    {
        [ProtoMember(1)]
        public int SceneVersion { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LayoutId { get; }
    }
}
