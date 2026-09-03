using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkmicInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string AccessKey { get; } = string.Empty;

        [ProtoMember(2)]
        public long LinkMicId { get; }

        [ProtoMember(3)]
        public bool Joinable { get; }

        [ProtoMember(4)]
        public int ConfluenceType { get; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string RtcExtInfo { get; } = string.Empty;

        [ProtoMember(6)]
        [DefaultValue("")]
        public string RtcAppId { get; } = string.Empty;

        [ProtoMember(7)]
        [DefaultValue("")]
        public string RtcAppSign { get; } = string.Empty;

        [ProtoMember(8)]
        [DefaultValue("")]
        public string LinkmicIdStr { get; } = string.Empty;

        [ProtoMember(9)]
        public long Vendor { get; }
    }
}
