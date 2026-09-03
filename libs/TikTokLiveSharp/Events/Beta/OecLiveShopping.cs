using TikTokLiveSharp.Events.Beta.Data;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class OecLiveShopping : AMessageData
    {
        #region InnerTypes
        public sealed class LiveShoppingData
        {
            public readonly string Title;
            public readonly string PriceString;
            public readonly string ImageUrl;
            public readonly string ShopUrl;
            public readonly ulong Data6;
            public readonly string ShopName;
            public readonly ulong Data8;
            public readonly string ShopUrl2;
            public readonly ulong Data10;
            public readonly ulong Data11;

            private LiveShoppingData(Models.Protobuf.UnknownObjects.OecLiveShoppingMessage.LiveShoppingData data)
            {
                Title = data?.Title ?? string.Empty;
                PriceString = data?.PriceString ?? string.Empty;
                ImageUrl = data?.ImageUrl ?? string.Empty;
                ShopUrl = data?.ShopUrl ?? string.Empty;
                Data6 = data?.Data6 ?? 0;
                ShopName = data?.ShopName ?? string.Empty;
                Data8 = data?.Data8 ?? 0;
                ShopUrl2 = data?.ShopUrl2 ?? string.Empty;
                Data10 = data?.Data10 ?? 0;
                Data11 = data?.Data11 ?? 0;
            }

            public static implicit operator LiveShoppingData(Models.Protobuf.UnknownObjects.OecLiveShoppingMessage.LiveShoppingData data) => new LiveShoppingData(data);
        }

        public sealed class LiveShoppingDetails
        {
            public readonly string Id1;
            public readonly string Data3;
            public readonly uint Data4;
            public readonly ulong Timestamp;
            public readonly ValueLabel Data6;

            private LiveShoppingDetails(Models.Protobuf.UnknownObjects.OecLiveShoppingMessage.LiveShoppingDetails details)
            {
                Id1 = details?.Id1 ?? string.Empty;
                Data3 = details?.Data3 ?? string.Empty;
                Data4 = details?.Data4 ?? 0;
                Timestamp = details?.Timestamp ?? 0;
                Data6 = details?.Data6;
            }

            public static implicit operator LiveShoppingDetails(Models.Protobuf.UnknownObjects.OecLiveShoppingMessage.LiveShoppingDetails details) => new LiveShoppingDetails(details);
        }
        #endregion

        public readonly uint Data2;
        public readonly LiveShoppingData Data4;
        public readonly TimestampContainer Data5;
        public readonly LiveShoppingDetails Data9;

        internal OecLiveShopping(Models.Protobuf.UnknownObjects.OecLiveShoppingMessage msg)
            : base(msg?.Header)
        {
            Data2 = msg?.Data2 ?? 0;
            Data4 = msg?.Data4;
            Data5 = msg?.Data5;
            Data9 = msg?.Data9;
        }
    }
}