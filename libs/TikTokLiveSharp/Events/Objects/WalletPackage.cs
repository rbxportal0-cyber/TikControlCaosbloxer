namespace TikTokLiveSharp.Events.Objects
{
    public sealed class WalletPackage
    {
        public readonly string IapId;
        public readonly string UsdPriceShow;

        private WalletPackage(Models.Protobuf.Objects.WalletPackage pkg)
        {
            IapId = pkg?.IapId ?? string.Empty;
            UsdPriceShow = pkg?.UsdPriceShow ?? string.Empty;
        }

        public static implicit operator WalletPackage(Models.Protobuf.Objects.WalletPackage pkg) => new WalletPackage(pkg);
    }
}
