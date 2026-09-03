using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LinkmicUserSettingInfo : AProtoBase
    {
        [ProtoMember(1)]
        public long UserId { get; }

        [ProtoMember(2)]
        public LinkmicUserSettingLayout Layout { get; }

        // TODO: Is an enum
        [ProtoMember(3)]
        public int FixMicNum { get; }

        // TODO: Is an enum
        [ProtoMember(4)]
        public int AllowRequestFromUser { get; }

        // TODO: Is an enum
        [ProtoMember(5)]
        public int AllowRequestFromFollowerOnly { get; }

        [ProtoMember(6)]
        public LinkmicApplierSortSetting ApplierSortSetting { get; }
    }
}
