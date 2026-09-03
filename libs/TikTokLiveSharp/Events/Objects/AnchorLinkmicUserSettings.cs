namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AnchorLinkmicUserSettings
    {
        public readonly bool IsTurnOn;
        public readonly bool AcceptMultiLinkmic;
        public readonly bool AcceptNotFollowerInvite;
        public readonly bool AllowGiftToOtherAnchors;
        public readonly bool BlockInvitationOfThisLive;
        public readonly bool ReceiveFriendMultiHostInvites;
        public readonly bool ReceiveFriendMultiHostApplication;
        public readonly bool BlockThisMultiHostInvites;
        public readonly bool BlockThisMultiHostApplication;
        public readonly bool ReceiveNotFriendMultiHostInvites;
        public readonly bool ReceiveNotFriendMultiHostApplication;
        public readonly bool AllowLiveNoticeOfFriends;

        private AnchorLinkmicUserSettings(Models.Protobuf.Objects.AnchorLinkmicUserSettings settings)
        {
            IsTurnOn = settings?.IsTurnOn ?? false;
            AcceptMultiLinkmic = settings?.AcceptMultiLinkmic ?? false;
            AcceptNotFollowerInvite = settings?.AcceptNotFollowerInvite ?? false;
            AllowGiftToOtherAnchors = settings?.AllowGiftToOtherAnchors ?? false;
            BlockInvitationOfThisLive = settings?.BlockInvitationOfThisLive ?? false;
            ReceiveFriendMultiHostInvites = settings?.ReceiveFriendMultiHostInvites ?? false;
            ReceiveFriendMultiHostApplication = settings?.ReceiveFriendMultiHostApplication ?? false;
            BlockThisMultiHostInvites = settings?.BlockThisMultiHostInvites ?? false;
            BlockThisMultiHostApplication = settings?.BlockThisMultiHostApplication ?? false;
            ReceiveNotFriendMultiHostInvites = settings?.ReceiveNotFriendMultiHostInvites ?? false;
            ReceiveNotFriendMultiHostApplication = settings?.ReceiveNotFriendMultiHostApplication ?? false;
            AllowLiveNoticeOfFriends = settings?.AllowLiveNoticeOfFriends ?? false;
        }

        public static implicit operator AnchorLinkmicUserSettings(Models.Protobuf.Objects.AnchorLinkmicUserSettings settings) => new AnchorLinkmicUserSettings(settings);
    }
}
