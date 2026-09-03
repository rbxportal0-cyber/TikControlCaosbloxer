using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LeaveJoinGroupContent
    {
        public readonly GroupPlayer Operator;
        public readonly long GroupChannelId;
        public readonly string LeaveSource;

        private LeaveJoinGroupContent(Models.Protobuf.Messages.LeaveJoinGroupContent content)
        {
            Operator = content?.Operator;
            GroupChannelId = content?.GroupChannelId ?? -1;
            LeaveSource = content?.LeaveSource ?? string.Empty;
        }

        public static implicit operator LeaveJoinGroupContent(Models.Protobuf.Messages.LeaveJoinGroupContent content) => new LeaveJoinGroupContent(content);
    }
}
