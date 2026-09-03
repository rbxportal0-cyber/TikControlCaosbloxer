namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerSysKickOutContent
    {
        public readonly long UserId;
        public readonly string LinkmicIdString;
        
        private LinkerSysKickOutContent(Models.Protobuf.Messages.LinkerSysKickOutContent content)
        {
            UserId = content?.UserId ?? -1;
            LinkmicIdString = content?.LinkmicIdStr ?? string.Empty;
        }

        public static implicit operator LinkerSysKickOutContent(Models.Protobuf.Messages.LinkerSysKickOutContent content) => new LinkerSysKickOutContent(content);
    }
}
