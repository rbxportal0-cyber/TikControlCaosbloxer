using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class PerceptionMessage : AProtoBase
    {
        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public PerceptionDialogInfo Dialog { get; }

        [ProtoMember(3)]
        public PunishEventInfo PunishInfo { get; }

        [ProtoMember(4)]
        public long EndTime { get; }

        [ProtoMember(5)]
        public bool ShowViolationWarning { get; }

        [ProtoMember(6)]
        public Text Toast { get; }

        [ProtoMember(7)]
        public int FloatStyle { get; }

        [ProtoMember(8)]
        public Text FloatText { get; }
    }
}
