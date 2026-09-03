using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerKickOutContent
    {
        public readonly long FromUserId;
        public readonly KickoutReason KickoutReason;

        private LinkerKickOutContent(Models.Protobuf.Messages.LinkerKickOutContent content)
        {
            FromUserId = content?.FromUserId ?? -1;
            KickoutReason = content?.KickoutReason ?? KickoutReason.Kickout_Reason_Unknown;
        }

        public static implicit operator LinkerKickOutContent(Models.Protobuf.Messages.LinkerKickOutContent content) => new LinkerKickOutContent(content);
    }
}
