using ProtoBuf;
using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class BadgeDetail : AProtoBase
    {
        [ProtoMember(1)]
        public Badge Badge { get; }

        [ProtoMember(2)]
        public List<BadgePreview> PreviewList { get; } = new List<BadgePreview>();

        [ProtoMember(3)]
        public AuditStatus BadgeAbbrAuditStatus { get; }

        [ProtoMember(4)]
        public AuditStatus BadgeDescAuditStatus { get; }

        [ProtoMember(5)]
        public bool Exist { get; }
    }
}
