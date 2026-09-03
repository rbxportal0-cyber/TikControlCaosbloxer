using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BaLeadsGenInfo : AProtoBase
    {
        [ProtoMember(1)]
        public bool LeadsGenPermission { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string LeadsGenModel { get; } = string.Empty;
    }
}
