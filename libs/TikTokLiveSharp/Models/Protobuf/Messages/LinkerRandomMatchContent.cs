using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerRandomMatchContent : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; }

        [ProtoMember(2)]
        public long RoomId { get; }

        [ProtoMember(3)]
        public long InviteType { get; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string MatchId { get; } = string.Empty;

        [ProtoMember(5)]
        public long InnerChannelId { get; }
    }
}
