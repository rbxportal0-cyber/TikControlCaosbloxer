using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.UnknownObjects.Data
{
    [ProtoContract]
    public partial class GiftDetailsData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; }

        [ProtoMember(2)]
        public Text Text2 { get; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Data11 { get; } = string.Empty;

        [ProtoMember(21)]
        public ListUser User21 { get; }

        [ProtoMember(22)]
        public GiftDataDetailed Details22 { get; }
    }
}
