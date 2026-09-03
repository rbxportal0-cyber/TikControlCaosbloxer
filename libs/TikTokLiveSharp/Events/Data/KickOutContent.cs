using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class KickOutContent
    {
        public readonly Player Offliner;
        public readonly KickoutReason KickoutReason;

        private KickOutContent(Models.Protobuf.Messages.KickOutContent content)
        {
            Offliner = content?.Offliner;
            KickoutReason = content?.KickoutReason ?? KickoutReason.Kickout_Reason_Unknown;
        }

        public static implicit operator KickOutContent(Models.Protobuf.Messages.KickOutContent content) => new KickOutContent(content);
    }
}
