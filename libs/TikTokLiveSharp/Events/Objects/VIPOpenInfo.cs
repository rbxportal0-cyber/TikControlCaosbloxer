namespace TikTokLiveSharp.Events.Objects
{
    public sealed class VIPOpenInfo
    {
        public readonly long OpenPrice;

        public readonly long RenewPrice;

        private VIPOpenInfo(Models.Protobuf.Objects.VIPOpenInfo openInfo)
        {
            OpenPrice = openInfo?.OpenPrice ?? -1;
            RenewPrice = openInfo?.RenewPrice ?? -1;
        }

        public static implicit operator VIPOpenInfo(Models.Protobuf.Objects.VIPOpenInfo openInfo) => new VIPOpenInfo(openInfo);
    }
}
