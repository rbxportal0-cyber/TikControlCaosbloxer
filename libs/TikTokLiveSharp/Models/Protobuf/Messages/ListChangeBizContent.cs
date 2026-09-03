using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class ListChangeBizContent : AProtoBase
    {
        [ProtoMember(1)]
        public Dictionary<long, CohostUserInfo> UserInfosMap { get; } = new Dictionary<long, CohostUserInfo>();
    }
}
