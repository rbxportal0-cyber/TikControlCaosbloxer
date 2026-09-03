using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class PrivilegeLogExtra : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string DataVersion { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string PrivilegeId { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string PrivilegeVersion { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string PrivilegeOrderId { get; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Level { get; } = string.Empty;
    }
}
