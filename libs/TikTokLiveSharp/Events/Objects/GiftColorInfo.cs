using System.Collections.Generic;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftColorInfo
    {
        public readonly long ColorId;
        public readonly string ColorName;
        public readonly IReadOnlyList<string> ColorValues;
        public readonly Picture ColorImage;
        public readonly Picture GiftImage;
        public readonly long ColorEffectId;
        public readonly bool IsDefault;

        private GiftColorInfo(Models.Protobuf.Objects.GiftColorInfo info)
        {
            ColorId = info?.ColorId ?? -1;
            ColorName = info?.ColorName ?? string.Empty;
            ColorValues = info?.ColorValuesList?.Count > 0 ? new List<string>(info.ColorValuesList).AsReadOnly() : new List<string>(0).AsReadOnly();
            ColorImage = info?.ColorImage;
            GiftImage = info?.GiftImage;
            ColorEffectId = info?.ColorEffectId ?? -1;
            IsDefault = info?.IsDefault ?? false;
        }

        public static implicit operator GiftColorInfo(Models.Protobuf.Objects.GiftColorInfo info) => new GiftColorInfo(info);
    }
}
