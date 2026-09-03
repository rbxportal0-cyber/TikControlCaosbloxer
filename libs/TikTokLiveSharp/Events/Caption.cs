namespace TikTokLiveSharp.Events
{
    /// <summary>
    /// Closed Captioning for Stream
    /// </summary>
    public sealed class Caption : AMessageData
    {
        public readonly long CaptionTime;

        public readonly string CaptionText;

        public readonly string ISOLanguage;

        public readonly long CaptionData;

        internal Caption(Models.Protobuf.Messages.CaptionMessage msg)
            : base(msg?.Header)
        {
            CaptionTime = msg?.Timestamp ?? -1;
            CaptionText = msg?.CaptionData?.Value ?? string.Empty;
            ISOLanguage = msg?.CaptionData?.ISOLanguage ?? string.Empty;
            CaptionData = msg?.Data3 ?? -1;
        }
    }
}