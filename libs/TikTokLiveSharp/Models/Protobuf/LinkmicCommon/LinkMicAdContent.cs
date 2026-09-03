using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.LinkmicCommon
{
    [ProtoContract]
    public partial class LinkMicAdContent : AProtoBase
    {
        [ProtoMember(1)]
        public long RoomId { get; }

        [ProtoMember(2)]
        public long AdId { get; }

        [ProtoMember(3)]
        public long Duration { get; }

        [ProtoMember(4)]
        public long PlayTimes { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Url { get; } = string.Empty;
    }
}
