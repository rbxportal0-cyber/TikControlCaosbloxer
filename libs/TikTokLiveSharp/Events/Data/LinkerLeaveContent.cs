namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerLeaveContent
    {
        public readonly long UserId;
        public readonly string LinkmicIdString;
        public readonly long SendLeaveUid;
        public readonly long LeaveReason;

        private LinkerLeaveContent(Models.Protobuf.Messages.LinkerLeaveContent content)
        {
            UserId = content?.UserId ?? -1;
            LinkmicIdString = content?.LinkmicIdStr ?? string.Empty;
            SendLeaveUid = content?.SendLeaveUid ?? -1;
            LeaveReason = content?.LeaveReason ?? -1;
        }

        public static implicit operator LinkerLeaveContent(Models.Protobuf.Messages.LinkerLeaveContent content) => new LinkerLeaveContent(content);
    }
}
