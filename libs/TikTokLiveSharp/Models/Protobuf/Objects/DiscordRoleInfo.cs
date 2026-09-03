using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class DiscordRoleInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string RoleIdStr { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string RoleName { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Permissions { get; } = string.Empty;

        [ProtoMember(4)]
        public bool IsPositionAboveBot { get; }

        [ProtoMember(5)]
        public bool IsPermissionHigherBot { get; }
    }
}
