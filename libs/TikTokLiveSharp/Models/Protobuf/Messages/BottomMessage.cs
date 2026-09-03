using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Has not actually been seen from Server yet.
    /// </summary>
    [ProtoContract]
    public partial class BottomMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(3)]
        public ShowType ShowType { get; }

        [ProtoMember(4)]
        public TextType TextType { get; }

        [ProtoMember(5)]
        public long Duration { get; }

        [ProtoMember(6)] 
        public BizType BizType { get; }

        [ProtoMember(7)]
        public long ViolationUserId { get; }
        
        [ProtoMember(8)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(9)]
        public int Style { get; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string DetailUrl { get; } = string.Empty;

        [ProtoMember(11)]
        public int FloatStyle { get; }
    }
}
