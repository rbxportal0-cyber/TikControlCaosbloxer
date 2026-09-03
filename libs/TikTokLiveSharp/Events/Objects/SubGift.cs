namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubGift
    {
        public readonly string SendSubGiftNotice;
        public readonly string SendUrl;
        public readonly long SubGiftNum;
        public readonly bool ShowEntrance;

        private SubGift(Models.Protobuf.Objects.SubGift subGift)
        {
            SendSubGiftNotice = subGift?.SendSubGiftNotice ?? string.Empty;
            SendUrl = subGift?.SendUrl ?? string.Empty;
            SubGiftNum = subGift?.SubGiftNum ?? -1;
            ShowEntrance = subGift?.ShowEntrance ?? false;
        }

        public static implicit operator SubGift(Models.Protobuf.Objects.SubGift subGift) => new SubGift(subGift);
    }
}
