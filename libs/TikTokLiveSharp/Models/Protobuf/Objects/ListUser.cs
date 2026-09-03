using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ListUser : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; }

        [ProtoMember(2)]
        public long LinkmicId { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;

        [ProtoMember(4)]
        public LinkListStatus Status { get; }

        [ProtoMember(5)]
        public LinkType LinkType { get; }

        [ProtoMember(6)]
        public int UserPosition { get; }

        [ProtoMember(7)]
        public LinkSilenceStatus SilenceStatus { get; }

        [ProtoMember(8)]
        public long ModifyTime { get; }

        [ProtoMember(9)]
        public long LinkerId { get; }

        [ProtoMember(10)]
        public LinkRoleType RoleType { get; }
    }
}
