using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class BarrageMessage : AProtoBase
    {
        public enum BarrageType
        {
            Unknown = 0,
            EComOrdering = 1,
            EComBuying = 2,
            Normal = 3,
            Subscribe = 4,
            EventView = 5,
            EventRegistered = 6,
            SubscribeGift = 7,
            UserUpgrade = 8,
            GradeUserEntranceNotification = 9,
            FansLevelUpgrade = 10,
            FansLevelEntrance = 11,
            GamePartnership = 12
        }

        [ProtoMember(1)]
        public Header Header { get; }

        [ProtoMember(2)]
        public BarrageEvent Event { get; }

        [ProtoMember(3)]
        public BarrageType MsgType { get; }

        [ProtoMember(4)]
        public Image Icon { get; }

        [ProtoMember(5)]
        public Text Content { get; }

        [ProtoMember(6)]
        public long Duration { get; }

        [ProtoMember(7)]
        public Image Background { get; }

        [ProtoMember(8)]
        public Image RightIcon { get; }

        [ProtoMember(100)]
        public BarrageTypeUserGradeParam UserGradeParam { get; }

        [ProtoMember(101)]
        public BarrageTypeFansLevelParam FansLevelParam { get; }

        [ProtoMember(102)]
        public BarrageTypeSubscribeGiftParam SubscribeGiftParam { get; }
    }
}
