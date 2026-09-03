using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerEnterContent : AProtoBase
    {
        [ProtoMember(1)]
        public List<ListUser> LinkedUsersList { get; } = new List<ListUser>();

        [ProtoMember(2)]
        public LinkmicMultiLiveEnum AnchorMultiLiveEnum { get; }

        [ProtoMember(3)]
        public LinkmicUserSettingInfo AnchorSettingInfo { get; }
    }
}
