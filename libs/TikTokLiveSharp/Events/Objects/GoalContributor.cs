using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GoalContributor
    {
        public readonly long UserId;
        public readonly Picture Avatar;
        public readonly string DisplayId;
        public readonly long Score;
        public readonly string UserIdString;
        public readonly bool InRoom;
        public readonly bool IsFriend;
        public readonly IReadOnlyList<Badge> BadgeList;
        public readonly bool FollowedByOwner;
        public readonly bool IsFirstContribute;

        private GoalContributor(Models.Protobuf.Objects.GoalContributor contributor)
        {
            UserId = contributor?.UserId ?? -1;
            Avatar = contributor?.Avatar;
            DisplayId = contributor?.DisplayId ?? string.Empty;
            Score = contributor?.Score ?? -1;
            UserIdString = contributor?.UserIdStr ?? string.Empty;
            InRoom = contributor?.InRoom ?? false;
            IsFriend = contributor?.IsFriend ?? false;
            BadgeList = contributor?.BadgeList?.Count > 0 ? contributor.BadgeList.Select(b => (Badge)b).ToList().AsReadOnly() : new List<Badge>(0).AsReadOnly();
            FollowedByOwner = contributor?.FollowByOwner ?? false;
            IsFirstContribute = contributor?.IsFistContribute ?? false;
        }

        public static implicit operator GoalContributor(Models.Protobuf.Objects.GoalContributor contributor) => new GoalContributor(contributor);
    }
}
