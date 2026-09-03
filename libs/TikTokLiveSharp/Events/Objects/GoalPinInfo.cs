namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GoalPinInfo
    {
        public readonly bool Pin;
        public readonly bool Unpin;
        public readonly long PinEndTime;

        private GoalPinInfo(Models.Protobuf.Objects.GoalPinInfo info)
        {
            Pin = info?.Pin ?? false;
            Unpin = info?.Unpin ?? false;
            PinEndTime = info?.PinEndTime ?? -1;
        }

        public static implicit operator GoalPinInfo(Models.Protobuf.Objects.GoalPinInfo info) => new GoalPinInfo(info);
    }
}
