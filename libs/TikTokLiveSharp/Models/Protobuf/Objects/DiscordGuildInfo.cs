using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class DiscordGuildInfo : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string GuildIdStr { get; } = string.Empty;

        [ProtoMember(2)]
        [DefaultValue("")]
        public string GuildName { get; } = string.Empty;

        [ProtoMember(3)]
        [DefaultValue("")]
        public string GuildIcon { get; } = string.Empty;

        [ProtoMember(4)]
        [DefaultValue("")]
        public string OwnerIdStr { get; set; } = string.Empty;

        [ProtoMember(5)]
        [DefaultValue("")]
        public string ReconnectUrl { get; } = string.Empty;

        [ProtoMember(6)]
        public List<DiscordRoleInfo> RolesList { get; } = new List<DiscordRoleInfo>();

        [ProtoMember(7)]
        public Image GuildIconImage { get; }
    }
}
