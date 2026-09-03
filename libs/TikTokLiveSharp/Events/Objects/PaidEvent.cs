namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PaidEvent
    {
        #region InnerTypes
        [System.Serializable]
        public enum PaidType
        {
            Free = 0,
            Paid = 1
        }
        #endregion

        public readonly long EventId;
        public readonly PaidType Paid_Type;

        private PaidEvent(Models.Protobuf.Objects.PaidEvent evt)
        {
            EventId = evt?.EventId ?? -1;
            Paid_Type = evt?.Paid_Type != null ? (PaidType)evt.Paid_Type : PaidType.Free;
        }

        public static implicit operator PaidEvent(Models.Protobuf.Objects.PaidEvent evt) => new PaidEvent(evt);
    }
}
