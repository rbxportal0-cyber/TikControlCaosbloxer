using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class CommunityContent : AProtoBase
    {
        [ProtoMember(1)]
        public CommunityContentType CommunityContentType { get; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string CommunityContentText { get; } = string.Empty;

        [ProtoMember(3)]
        public Image CommunityContentImage { get; }

        [ProtoMember(4)]
        public int CommunityContentDisplayOrder { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string TitleTemplateId { get; } = string.Empty;
    }
}
