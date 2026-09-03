using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// User sent one or multiple likes to Stream. Maxes at 15 likes per message
    /// </summary>
    [ProtoContract]
    public partial class LikeMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        /// <summary>
        /// Number of Likes for this message. Maxes at 15
        /// </summary>
        [ProtoMember(2)]
        public long Count { get; }

        /// <summary>
        /// Total Likes for Stream
        /// </summary>
        [ProtoMember(3)]
        public long Total { get; }

        [ProtoMember(4)]
        public long Color { get; }

        /// <summary>
        /// Sender of Like(s)
        /// </summary>
        [ProtoMember(5)]
        public User User { get; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Icon { get; } = string.Empty;

        [ProtoMember(7)] 
        public List<Image> IconsList { get; } = new List<Image>();

        /// <summary>
        /// Not always filled. The Data in Header IS always filled.
        /// </summary>
        [ProtoMember(8)]
        public List<SpecifiedDisplayText> SpecifiedDisplayTextList { get; } = new List<SpecifiedDisplayText>();

        [ProtoMember(9)]
        public long EffectCnt { get; }

        [ProtoMember(10)] 
        public List<LikeEffect> LikeEffectList { get; } = new List<LikeEffect>();
    }
}
