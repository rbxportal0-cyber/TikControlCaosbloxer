using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TimerDetail : AProtoBase
    {
        #region InnerTypes
        [ProtoContract]
        [System.Serializable]
        public enum AntidirtStatus
        {
            Pass = 0,
            Failed = 1
        }
        #endregion

        [ProtoMember(1)]
        public long TimerId { get; }

        [ProtoMember(2)]
        public long AnchorId { get; }

        [ProtoMember(3)]
        public long StartTimestampS { get; }

        [ProtoMember(4)]
        public long StartCountdownTimeS { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string AnchorSideTitle { get; } = string.Empty;

        [ProtoMember(6)]
        [DefaultValue("")]
        public string UserSideTitle { get; } = string.Empty;

        [ProtoMember(7)]
        public long TimeIncreasePerSubS { get; }

        [ProtoMember(8)]
        public long TimeIncreaseCapS { get; }

        [ProtoMember(9)]
        public int SubCount { get; }

        [ProtoMember(10)]
        public bool TimeIncreaseReachCap { get; }

        [ProtoMember(11)]
        public long TotalPauseTimeS { get; }

        [ProtoMember(12)]
        public long LastPauseTimestampS { get; }

        [ProtoMember(13)]
        public long TotalTimeS { get; }

        [ProtoMember(14)]
        public long RemainingTimeS { get; }

        [ProtoMember(15)]
        public long TimestampS { get; }

        [ProtoMember(16)]
        public long StickerX { get; }

        [ProtoMember(17)]
        public long StickerY { get; }

        [ProtoMember(18)]
        public long ScreenW { get; }

        [ProtoMember(19)]
        public long ScreenH { get; }

        [ProtoMember(20)]
        public TimerStatus TimerStatus { get; }

        [ProtoMember(21)]
        public AntidirtStatus Antidirt_Status { get; }

        [ProtoMember(22)]
        public AuditStatus Audit_Status { get; }
    }
}
