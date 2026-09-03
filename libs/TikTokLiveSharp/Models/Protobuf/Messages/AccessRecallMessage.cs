using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class AccessRecallMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public int Status { get; }

        [ProtoMember(3)]
        public long Duration { get; }

        [ProtoMember(4)]
        public long EndTime { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Scene { get; } = string.Empty;

        [ProtoMember(6)]
        public Text Notice { get; }

        [ProtoMember(7)]
        public Text Content { get; }

        [ProtoMember(8)]
        public PunishEventInfo PunishInfo { get; }
    }
}
