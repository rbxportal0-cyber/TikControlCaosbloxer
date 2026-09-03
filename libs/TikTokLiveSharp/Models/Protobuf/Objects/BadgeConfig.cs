using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgeConfig : AProtoBase
    {
        [ProtoMember(1)]
        public BadgeLimit BadgeLmt { get; }

        [ProtoMember(2)]
        public List<OriginBadgeInfo> OriginBadgeImgList { get; } = new List<OriginBadgeInfo>();
    }
}
