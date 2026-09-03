using System.Collections.Generic;
using System.Collections.ObjectModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class UserVIPInfo
    {
        public readonly long VipLevel;

        public readonly string VipLevelName;

        public readonly VIPStatus Status;

        public readonly long StartTime;

        public readonly long EndTime;

        public readonly long RemainingDays;

        public readonly long TotalConsume;

        public readonly long TargetConsume;

        public readonly VIPBadge Badge;

        public readonly IReadOnlyDictionary<long, bool> Privileges;

        private UserVIPInfo(Models.Protobuf.Objects.UserVIPInfo vipInfo)
        {
            VipLevel = vipInfo?.VipLevel ?? -1;
            VipLevelName = vipInfo?.VipLevelName ?? string.Empty;
            Status = vipInfo?.Status ?? VIPStatus.VIPStatus_Unknown;
            StartTime = vipInfo?.StartTime ?? -1;
            EndTime = vipInfo?.EndTime ?? -1;
            RemainingDays = vipInfo?.RemainingDays ?? -1;
            TotalConsume = vipInfo?.TotalConsume ?? -1;
            TargetConsume = vipInfo?.TargetConsume ?? -1;
            Badge = vipInfo?.Badge;
            Privileges = vipInfo?.PrivilegesMap?.Count > 0 ? new ReadOnlyDictionary<long, bool>(vipInfo.PrivilegesMap) : new ReadOnlyDictionary<long, bool>(new Dictionary<long, bool>(0));
        }

        public static implicit operator UserVIPInfo(Models.Protobuf.Objects.UserVIPInfo vipInfo) => new UserVIPInfo(vipInfo);
    }
}
