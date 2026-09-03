namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftTrayInfo
    {
        public readonly Picture TrayDynamicImage;
        public readonly bool CanMirror;

        private GiftTrayInfo(Models.Protobuf.Objects.GiftTrayInfo info)
        {
            TrayDynamicImage = info?.TrayDynamicImage;
            CanMirror = info?.CanMirror ?? false;
        }

        public static implicit operator GiftTrayInfo(Models.Protobuf.Objects.GiftTrayInfo info) => new GiftTrayInfo(info);
    }
}
