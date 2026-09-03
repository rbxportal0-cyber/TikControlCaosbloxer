using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LeaveContent
    {
        public readonly Player Leaver;
        public readonly long LeaveReason;

        private LeaveContent(Models.Protobuf.Messages.LeaveContent content)
        {
            Leaver = content?.Leaver;
            LeaveReason = content?.LeaveReason ?? -1;
        }

        public static implicit operator LeaveContent(Models.Protobuf.Messages.LeaveContent content) => new LeaveContent(content);
    }
}
