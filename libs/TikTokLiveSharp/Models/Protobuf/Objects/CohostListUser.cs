using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CohostListUser : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string NickName { get; } = string.Empty;

        [ProtoMember(3)]
        public Image AvatarThumb { get; }

        [ProtoMember(4)]
        public long LinkedTime { get; }

        [ProtoMember(5)]
        public LinkmicPlayType PlayType { get; }

        [ProtoMember(6)]
        public long RoomId { get; }

        [ProtoMember(7)]
        public LinkmicUserStatus LinkmicUserStatus { get; }

        [ProtoMember(8)]
        public long LinkRemainingTime { get; }

        [ProtoMember(9)]
        public CoHostPermissionType PermissionType { get; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string DisplayId { get; } = string.Empty;

        [ProtoMember(11)]
        public long FollowStatus { get; }

        [ProtoMember(12)]
        public bool IsLowVersion { get; }

        [ProtoMember(13)]
        public long RivalUserId { get; }

        [ProtoMember(14)]
        public long RivalRoomId { get; }

        [ProtoMember(15)]
        public bool IsInitiator { get; }

        [ProtoMember(16)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;

        [ProtoMember(17)]
        public long BestTeammateUid { get; }

        [ProtoMember(18)]
        public bool HasTopicPerm { get; }

        [ProtoMember(19)]
        public long InnerChannelId { get; }
    }
}
