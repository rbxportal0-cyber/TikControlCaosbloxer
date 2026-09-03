namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftInfoInBox
    {
        public readonly long GiftId;
        public readonly long EffectId;
        public readonly long ColorId;
        public readonly int RemainTimes;

        private GiftInfoInBox(Models.Protobuf.Objects.GiftInfoInBox info)
        {
            GiftId = info?.GiftId ?? -1;
            EffectId = info?.EffectId ?? -1;
            ColorId = info?.ColorId ?? -1;
            RemainTimes = info?.RemainTimes ?? -1;
        }

        public static implicit operator GiftInfoInBox(Models.Protobuf.Objects.GiftInfoInBox info) => new GiftInfoInBox(info);
    }
}
