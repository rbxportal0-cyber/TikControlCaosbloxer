using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class GoalUpdate : AMessageData
    {
        public readonly Indicator Indicator;
        public readonly Goal Goal;
        public readonly long ContributorId;
        public readonly Picture ContributorAvatar;
        public readonly string ContributorDisplayId;
        public readonly SubGoal SubGoal;
        public readonly long ContributeCount;
        public readonly long ContributeScore;
        public readonly long GiftRepeatCount;
        public readonly string ContributorIdStr;
        public readonly bool Pin;
        public readonly bool Unpin;
        public readonly GoalPinInfo PinInfo;
        
        internal GoalUpdate(Models.Protobuf.Messages.GoalUpdateMessage msg)
            : base(msg?.Header)
        {
            Indicator = msg?.Indicator;
            Goal = msg?.Goal;
            ContributorId = msg?.ContributorId ?? -1;
            ContributorAvatar = msg?.ContributorAvatar;
            ContributorDisplayId = msg?.ContributorDisplayId ?? string.Empty;
            SubGoal = msg?.SubGoal;
            ContributeCount = msg?.ContributeCount ?? -1;
            ContributeScore = msg?.ContributeScore ?? -1;
            GiftRepeatCount = msg?.GiftRepeatCount ?? -1;
            ContributorIdStr = msg?.ContributorIdStr ?? string.Empty;
            Pin = msg?.Pin ?? false;
            Unpin = msg?.Unpin ?? false;
            PinInfo = msg?.PinInfo;
        }
    }
}