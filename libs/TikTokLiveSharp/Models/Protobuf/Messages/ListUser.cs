using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ListUser : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; }

        [ProtoMember(2)]
        public long ModifyTime { get; }

        [ProtoMember(3)]
        public LinkType LinkType { get; }

        [ProtoMember(4)]
        public LinkmicRoleType RoleType { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;

        [ProtoMember(6)]
        public long PayedMoney { get; }

        [ProtoMember(7)]
        public long FanTicket { get; }

        [ProtoMember(8)]
        public int FanTicketIconType { get; }
    }
}
