using System.Collections.Generic;
using TikTokLiveSharp.Events.Beta.Data;
using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class GiftBroadcast : AMessageData
    {
        #region InnerTypes
        public sealed class GiftBroadcastData
        {
            public sealed class GiftBroadCastImageDataContainer
            {
                public sealed class GiftBroadcastImageData
                {
                    public readonly uint Data1;
                    public readonly uint Data2;
                    public readonly IReadOnlyList<string> Urls;
                    public readonly string Uri;

                    private GiftBroadcastImageData(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData.GiftBroadCastImageDataContainer.GiftBroadcastImageData data)
                    {
                        Data1 = data?.Data1 ?? 0;
                        Data2 = data?.Data2 ?? 0;
                        Urls = data?.Urls?.Count > 0 ? data.Urls.AsReadOnly() : new List<string>(0).AsReadOnly();
                    }

                    public static implicit operator GiftBroadcastImageData(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData.GiftBroadCastImageDataContainer.GiftBroadcastImageData data) => new GiftBroadcastImageData(data);
                }

                public readonly uint Data1;
                public readonly GiftBroadcastImageData Data2;

                private GiftBroadCastImageDataContainer(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData.GiftBroadCastImageDataContainer container)
                {
                    Data1 = container?.Data1 ?? 0;
                    Data2 = container?.Data2;
                }

                public static implicit operator GiftBroadCastImageDataContainer(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData.GiftBroadCastImageDataContainer container) => new GiftBroadCastImageDataContainer(container);
            }

            public readonly RoomNotifyMessage RoomNotifyMessage;
            public readonly string Uri;
            public readonly uint Data3;
            public readonly GiftBroadCastImageDataContainer Data6;
            public readonly string NotifyType;
            public readonly ulong Data10;
            public readonly Picture Data11;

            private GiftBroadcastData(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData data)
            {
                RoomNotifyMessage = data?.RoomNotifyMessage;
                Uri = data?.Uri ?? string.Empty;
                Data3 = data?.Data3 ?? 0;
                Data6 = data?.Data6;
                NotifyType = data?.NotifyType ?? string.Empty;
                Data10 = data?.Data10 ?? 0;
                Data11 = data?.Data11;
            }

            public static implicit operator GiftBroadcastData(Models.Protobuf.UnknownObjects.GiftBroadcastMessage.GiftBroadcastData data) => new GiftBroadcastData(data);
        }
        #endregion

        public readonly ulong Data2;
        public readonly Picture Picture3;
        public readonly GiftBroadcastData Data4;

        internal GiftBroadcast(Models.Protobuf.UnknownObjects.GiftBroadcastMessage msg)
            : base(msg?.Header)
        {
            Data2 = msg?.Data2 ?? 0;
            Picture3 = msg?.Picture3;
            Data4 = msg?.Data4;
        }
    }
}