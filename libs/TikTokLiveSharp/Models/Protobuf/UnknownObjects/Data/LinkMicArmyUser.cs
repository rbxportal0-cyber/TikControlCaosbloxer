using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class LinkMicArmyUser : AProtoBase
    {
        [ProtoMember(1)]
        public long Id { get; }

        [ProtoMember(2)]
        public long Data2 { get; } // Score?

        [ProtoMember(3)]
        [DefaultValue("")]
        public string UserName { get; } = string.Empty;

        [ProtoMember(4)]
        public Image Avatar { get; }
    }
}
