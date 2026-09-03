using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TimerConfig : AProtoBase
    {
        [ProtoMember(1)]
        public int MaxTitleLength { get; }

        [ProtoMember(2)]
        public long DefaultStartCountdownTimeS { get; }

        [ProtoMember(3)]
        public long MaxStartCountdownTimeS { get; }

        [ProtoMember(4)]
        public long DefaultTimeIncreasePerSubS { get; }

        [ProtoMember(5)]
        public long DefaultTimeIncreaseCapS { get; }

        [ProtoMember(6)]
        public long MaxTimeIncreaseCapS { get; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string BottomButtonText { get; } = string.Empty;
    }
}
