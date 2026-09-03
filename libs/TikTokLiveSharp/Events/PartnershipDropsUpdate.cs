namespace TikTokLiveSharp.Events
{
    public sealed class PartnershipDropsUpdate : AMessageData
    {
        [System.Serializable]
        public enum ChangeMode
        {
            Change_Mode_Show = 0,
            Change_Mode_Update = 1,
            Change_Mode_Close = 2
        }
        
        public readonly ChangeMode Change_Mode;
        public readonly string DropsId;
        public readonly string TaskId;
        public readonly string EventId;
        public readonly long AnchorUid;

        internal PartnershipDropsUpdate(Models.Protobuf.Messages.PartnershipDropsUpdateMessage msg)
            : base(msg?.Header)
        {
            Change_Mode = msg?.Change_Mode != null ? (ChangeMode)msg.Change_Mode : ChangeMode.Change_Mode_Show;
            DropsId = msg?.DropsId ?? string.Empty;
            TaskId = msg?.TaskId ?? string.Empty;
            EventId = msg?.EventId ?? string.Empty;
            AnchorUid = msg?.AnchorUid ?? -1;
        }
    }
}