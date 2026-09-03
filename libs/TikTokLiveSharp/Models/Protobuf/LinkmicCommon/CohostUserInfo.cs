using System.ComponentModel;
using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class CohostUserInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long PermissionType { get; }

        [ProtoMember(2)]
        public SourceType SourceType { get; }

        [ProtoMember(3)]
        public bool IsLowVersion { get; }

        [ProtoMember(4)]
        public long BestTeammateUid { get; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Nickname { get; } = string.Empty;

        [ProtoMember(12)]
        [DefaultValue("")]
        public string DisplayId { get; } = string.Empty;

        [ProtoMember(13)]
        public Image AvatarThumb { get; }

        [ProtoMember(14)]
        public long FollowStatus { get; }
    }
}
