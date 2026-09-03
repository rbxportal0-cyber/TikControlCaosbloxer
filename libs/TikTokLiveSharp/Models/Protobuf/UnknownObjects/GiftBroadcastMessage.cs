using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects
{
    [ProtoContract]
    public partial class GiftBroadcastMessage : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        public partial class GiftBroadcastData : AProtoBase
        {
            [ProtoContract]
            public partial class GiftBroadCastImageDataContainer : AProtoBase
            {
                [ProtoContract]
                public partial class GiftBroadcastImageData : AProtoBase
                {
                    [ProtoMember(1)]
                    public uint Data1 { get; }

                    [ProtoMember(2)]
                    public uint Data2 { get; }

                    [ProtoMember(3)]
                    public List<string> Urls { get; } = new List<string>();

                    [ProtoMember(4)]
                    [DefaultValue("")]
                    public string Uri { get; } = string.Empty;
                }

                [ProtoMember(1)]
                public uint Data1 { get; }

                [ProtoMember(2)]
                public GiftBroadcastImageData Data2 { get; }
            }

            [ProtoMember(1)]
            public RoomNotifyMessage RoomNotifyMessage { get; }

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Uri { get; } = string.Empty;

            [ProtoMember(3)]
            public uint Data3 { get; }

            [ProtoMember(6)]
            public GiftBroadCastImageDataContainer Data6 { get; }

            [ProtoMember(9)]
            [DefaultValue("")]
            public string NotifyType { get; } = string.Empty;

            [ProtoMember(10)]
            public ulong Data10 { get; }

            [ProtoMember(11)]
            public Image Data11 { get; }
        }
        #endregion

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public ulong Data2 { get; }

        [ProtoMember(3)]
        public Image Picture3 { get; }

        [ProtoMember(4)]
        public GiftBroadcastData Data4 { get; }
    }
}
