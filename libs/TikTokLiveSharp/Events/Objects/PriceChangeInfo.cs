namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PriceChangeInfo
    {
        public readonly bool IsPriceChanged;
        public readonly string NewPrice;
        public readonly string OldPrice;
        public readonly long NextBillingDate;
        public readonly long DaysLeftToAgreeChange;
        public readonly bool IsFirstEntrance;
        public readonly bool IsConsentRequired;
        public readonly string ContractId;
        public readonly string OrderId;
        public readonly long NoConfirmCancelContractDate;

        private PriceChangeInfo(Models.Protobuf.Objects.PriceChangeInfo info)
        {
            IsPriceChanged = info?.IsPriceChanged ?? false;
            NewPrice = info?.NewPrice ?? string.Empty;
            OldPrice = info?.OldPrice ?? string.Empty;
            NextBillingDate = info?.NextBillingDate ?? -1;
            DaysLeftToAgreeChange = info?.DaysLeftToAgreeChange ?? -1;
            IsFirstEntrance = info?.IsFirstEntrance ?? false;
            IsConsentRequired = info?.IsConsentRequired ?? false;
            ContractId = info?.ContractId ?? string.Empty;
            OrderId = info?.OrderId ?? string.Empty;
            NoConfirmCancelContractDate = info?.NoConfirmCancelContractDate ?? -1;
        }

        public static implicit operator PriceChangeInfo(Models.Protobuf.Objects.PriceChangeInfo info) => new PriceChangeInfo(info);
    }
}
