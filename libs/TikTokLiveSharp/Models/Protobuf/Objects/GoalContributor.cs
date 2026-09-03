using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalContributor : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        public Image Avatar { get; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string DisplayId { get; } = string.Empty;

        [ProtoMember(4)]
        public long Score { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string UserIdStr { get; } = string.Empty;

        [ProtoMember(6)]
        public bool InRoom { get; }

        [ProtoMember(7)]
        public bool IsFriend { get; }

        [ProtoMember(8)]
        public List<BadgeStruct> BadgeList { get; } = new List<BadgeStruct>();

        [ProtoMember(9)]
        public bool FollowByOwner { get; }

        [ProtoMember(10)]
        public bool IsFistContribute { get; }
    }
}
