using TikTokLiveSharp.Events.Objects;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class CohostUserInfo
    {
        public readonly long PermissionType;
        public readonly SourceType SourceType;
        public readonly bool IsLowVersion;
        public readonly long BestTeammateUid;
        public readonly string Nickname;
        public readonly string DisplayId;
        public readonly Picture AvatarThumb;
        public readonly long FollowStatus;

        private CohostUserInfo(Models.Protobuf.LinkmicCommon.CohostUserInfo info)
        {
            PermissionType = info?.PermissionType ?? -1;
            SourceType = info?.SourceType ?? SourceType.Source_Type_Unknown;
            IsLowVersion = info?.IsLowVersion ?? false;
            BestTeammateUid = info?.BestTeammateUid ?? -1;
            Nickname = info?.Nickname ?? string.Empty;
            DisplayId = info?.DisplayId ?? string.Empty;
            AvatarThumb = info?.AvatarThumb;
            FollowStatus = info?.FollowStatus ?? -1;
        }

        public static implicit operator CohostUserInfo(Models.Protobuf.LinkmicCommon.CohostUserInfo info) => new CohostUserInfo(info);
    }
}
