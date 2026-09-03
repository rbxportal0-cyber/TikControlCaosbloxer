using System.Collections.Generic;
using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class RoomNotifyMessage : AProtoBase
    {
        [ProtoContract]
        public partial class NotifyData : AProtoBase
        {
            [ProtoMember(1)]
            [DefaultValue("")]
            public string Type { get; } = string.Empty;

            [ProtoMember(2)]
            [DefaultValue("")]
            public string Label { get; } = string.Empty;

            [ProtoMember(3)]
            public Text Text3 { get; }

            [ProtoMember(4)]
            public List<GiftDetailsData> Data4 { get; } = new List<GiftDetailsData>();
        }

        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; } = string.Empty;

        [ProtoMember(2)]
        public ulong Id1 { get; }

        [ProtoMember(3)]
        public ulong Id2 { get; }

        [ProtoMember(4)]
        public ulong Timestamp { get; }

        [ProtoMember(5)]
        public NotifyData Data5 { get; }
    }
}
