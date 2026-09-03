namespace TikTokLiveSharp.Events.Data
{
    public sealed class BarrageTypeSubscribeGiftParam
    {
        public readonly long GiftSubCount;
        public readonly bool ShowGiftSubCount;

        private BarrageTypeSubscribeGiftParam(Models.Protobuf.Messages.BarrageTypeSubscribeGiftParam barrageGiftParam)
        {
            GiftSubCount = barrageGiftParam?.GiftSubCount ?? -1;
            ShowGiftSubCount = barrageGiftParam?.ShowGiftSubCount ?? false;
        }

        public static implicit operator BarrageTypeSubscribeGiftParam(Models.Protobuf.Messages.BarrageTypeSubscribeGiftParam barrageGiftParam) => new BarrageTypeSubscribeGiftParam(barrageGiftParam);
    }
}
