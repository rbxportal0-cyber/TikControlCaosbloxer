namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkmicInfo
    {
        public readonly string AccessKey;
        public readonly long LinkMicId;
        public readonly bool Joinable;
        public readonly int ConfluenceType;
        public readonly string RtcExtInfo;
        public readonly string RtcAppId;
        public readonly string RtcAppSign;
        public readonly string LinkmicIdString;
        public readonly long Vendor;

        private LinkmicInfo(Models.Protobuf.Messages.LinkmicInfo info)
        {
            AccessKey = info?.AccessKey ?? string.Empty;
            LinkMicId = info?.LinkMicId ?? -1;
            Joinable = info?.Joinable ?? false;
            ConfluenceType = info?.ConfluenceType ?? -1;
            RtcExtInfo = info?.RtcExtInfo ?? string.Empty;
            RtcAppId = info?.RtcAppId ?? string.Empty;
            RtcAppSign = info?.RtcAppSign ?? string.Empty;
            LinkmicIdString = info?.LinkmicIdStr ?? string.Empty;
            Vendor = info?.Vendor ?? -1;
        }

        public static implicit operator LinkmicInfo(Models.Protobuf.Messages.LinkmicInfo info) => new LinkmicInfo(info);
    }
}
