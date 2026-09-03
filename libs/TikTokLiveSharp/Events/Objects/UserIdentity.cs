namespace TikTokLiveSharp.Events.Objects
{
    public sealed class UserIdentity
    {
        public readonly bool IsGiftGiverOfHost;

        public readonly bool IsSubscriberOfHost;

        public readonly bool IsMutualFollowingWithHost;

        public readonly bool IsFollowerOfHost;

        public readonly bool IsModeratorOfHost;

        public readonly bool IsHost;

        private UserIdentity(Models.Protobuf.Objects.UserIdentity userIdentity)
        {
            IsGiftGiverOfHost = userIdentity?.IsGiftGiverOfAnchor ?? false;
            IsSubscriberOfHost = userIdentity?.IsSubscriberOfAnchor ?? false;
            IsMutualFollowingWithHost = userIdentity?.IsMutualFollowingWithAnchor ?? false;
            IsFollowerOfHost = userIdentity?.IsFollowerOfAnchor ?? false;
            IsModeratorOfHost = userIdentity?.IsModeratorOfAnchor ?? false;
            IsHost = userIdentity?.IsAnchor ?? false;
        }

        public static implicit operator UserIdentity(Models.Protobuf.Objects.UserIdentity userIdentity) => new UserIdentity(userIdentity);
    }
}
