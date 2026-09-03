using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BattleUserSettings : AProtoBase
    {
        [ProtoMember(1)]
        public bool IsTurnOn { get; }

        [ProtoMember(2)]
        public bool AcceptNotFollowerInvite { get; }

        [ProtoMember(3)]
        public bool AllowGiftToOtherAnchors { get; }
    }
}
