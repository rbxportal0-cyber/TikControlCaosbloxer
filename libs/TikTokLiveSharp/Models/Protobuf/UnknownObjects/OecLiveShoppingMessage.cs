using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class OecLiveShoppingMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class LiveShoppingData : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Title { get; } = string.Empty;

            [ProtoMember(2)]
            [DefaultValue("")]
            public string PriceString { get; } = string.Empty;

            [ProtoMember(3)]
            [DefaultValue("")]
            public string ImageUrl { get; } = string.Empty;

            [ProtoMember(4)]
            [DefaultValue("")]
            public string ShopUrl { get; } = string.Empty;

            [ProtoMember(6)]
            public ulong Data6 { get; }

            [ProtoMember(7)]
            [DefaultValue("")]
            public string ShopName { get; } = string.Empty;

            [ProtoMember(8)]
            public ulong Data8 { get; }

            [ProtoMember(9)]
            [DefaultValue("")]
            public string ShopUrl2 { get; } = string.Empty;

            [ProtoMember(10)]
            public ulong Data10 { get; }

            [ProtoMember(11)]
            public ulong Data11 { get; }
        }

        [ProtoContract]
        public partial class LiveShoppingDetails : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Id1 { get; } = string.Empty;

            [ProtoMember(3)]
            [DefaultValue("")]
            public string Data3 { get; } = string.Empty;

            [ProtoMember(4)]
            public uint Data4 { get; }

            [ProtoMember(5)]
            public ulong Timestamp { get; }

            [ProtoMember(6)]
            public ValueLabel Data6 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public uint Data2 { get; }

        [ProtoMember(4)]
        public LiveShoppingData Data4 { get; }

        [ProtoMember(5)]
        public TimestampContainer Data5 { get; }

        [ProtoMember(9)]
        public LiveShoppingDetails Data9 { get; }
    }
}
