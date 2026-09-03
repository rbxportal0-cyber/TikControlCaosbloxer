namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PriceTier
    {
        public readonly long PriceTierGrade;
        public readonly string USDPrice;
        public readonly string LocalPrice;
        public readonly string PriceHint;
        public readonly bool IsDefault;

        private PriceTier(Models.Protobuf.Objects.PriceTier tier)
        {
            PriceTierGrade = tier?.PriceTierGrade ?? -1;
            USDPrice = tier?.USDPrice ?? string.Empty;
            LocalPrice = tier?.LocalPrice ?? string.Empty;
            PriceHint = tier?.PriceHint ?? string.Empty;
            IsDefault = tier?.IsDefault ?? false;
        }

        public static implicit operator PriceTier(Models.Protobuf.Objects.PriceTier tier) => new PriceTier(tier);
    }
}
