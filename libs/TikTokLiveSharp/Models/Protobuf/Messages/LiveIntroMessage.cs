using System.Collections.Generic;
using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Intro Message from Host
    /// </summary>
    [ProtoContract]
    public partial class LiveIntroMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public long RoomId { get; }

        [ProtoMember(3)]
        public AuditStatus AuditStatus { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Content { get; } = string.Empty;

        [ProtoMember(5)]
        public User Host { get; }

        [ProtoMember(6)]
        public int IntroMode { get; }

        [ProtoMember(7)]
        public List<BadgeStruct> Badges { get; } = new List<BadgeStruct>();

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Language { get; } = string.Empty;
    }
}
