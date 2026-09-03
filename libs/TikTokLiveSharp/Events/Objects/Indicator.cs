using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Indicator
    {
        public readonly string Key;
        public readonly IndicatorOp Op;

        private Indicator(Models.Protobuf.Objects.Indicator indicator)
        {
            Key = indicator?.Key ?? string.Empty;
            Op = indicator?.Op ?? IndicatorOp.IndicatorOpUnknown;
        }

        public static implicit operator Indicator(Models.Protobuf.Objects.Indicator indicator) => new Indicator(indicator);
    }
}
