using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class SubTimerSticker : AProtoBase
    {
        [ProtoMember(1)]
        public SubTimerStickerChangeType Type { get; }

        [ProtoMember(2)]
        public long TimerId { get; }

        [ProtoMember(3)]
        public TimerOpType OpType { get; }

        [ProtoMember(4)]
        public TimerStatus TimerStatus { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string AnchorSideTitle { get; } = string.Empty;

        [ProtoMember(6)]
        [DefaultValue("")]
        public string UserSideTitle { get; } = string.Empty;

        [ProtoMember(7)]
        public int SubIncreaseCount { get; }

        [ProtoMember(8)]
        public long TimeIncreasePerSub { get; }

        [ProtoMember(9)]
        public long TimeIncrease { get; }

        [ProtoMember(10)]
        public long TotalTime { get; }

        [ProtoMember(11)]
        public long RemainingTime { get; }

        [ProtoMember(12)]
        public long Timestamp { get; }

        [ProtoMember(13)]
        public long StickerX { get; }

        [ProtoMember(14)]
        public long StickerY { get; }

        [ProtoMember(15)]
        public long ScreenW { get; }

        [ProtoMember(16)]
        public long ScreenH { get; }
    }
}
