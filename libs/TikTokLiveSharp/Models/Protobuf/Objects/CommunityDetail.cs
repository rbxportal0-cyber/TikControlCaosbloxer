using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CommunityDetail : AProtoBase
    {
        [ProtoMember(1)]
        public List<CommunityContent> CommunityContentList { get; } = new List<CommunityContent>();

        [ProtoMember(2)]
        public AuditStatus AuditStatus { get; }
    }
}
