using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftSubGoal : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Name { get; } = string.Empty;

        [ProtoMember(2)]
        public Image Icon { get; }

        [ProtoMember(3)]
        public long DiamondCount { get; }

        [ProtoMember(4)]
        public int Type { get; }
    }
}
