using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LinkmicAudienceEmoji : AProtoBase
    {
        [ProtoMember(1)]
        public long EmojiId { get; }

        [ProtoMember(2)]
        public bool IsRandom { get; }

        [ProtoMember(3)]
        public Image EmojiImage { get; }

        [ProtoMember(4)]
        public Image EmojiDynamicImage { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string EmojiName { get; } = string.Empty;

        [ProtoMember(6)]
        public long AnimationDurationMs { get; }

        [ProtoMember(7)]
        public long EmojiResultDurationMs { get; }
    }
}
