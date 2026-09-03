using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class DiscordGuildInfo
    {
        public readonly string GuildId;
        public readonly string GuildName;
        public readonly string GuildIcon;
        public readonly string OwnerId;
        public readonly string ReconnectUrl;
        public readonly IReadOnlyList<DiscordRoleInfo> Roles;
        public readonly Picture GuildIconImage;

        private DiscordGuildInfo(Models.Protobuf.Objects.DiscordGuildInfo info)
        {
            GuildId = info?.GuildIdStr ?? string.Empty;
            GuildName = info?.GuildName ?? string.Empty;
            GuildIcon = info?.GuildIcon ?? string.Empty;
            OwnerId = info?.OwnerIdStr ?? string.Empty;
            ReconnectUrl = info?.ReconnectUrl ?? string.Empty;
            Roles = info?.RolesList?.Count > 0 ? info.RolesList.Select(r => (DiscordRoleInfo)r).ToList().AsReadOnly() : new List<DiscordRoleInfo>(0).AsReadOnly();
            GuildIconImage = info?.GuildIconImage;
        }

        public static implicit operator DiscordGuildInfo(Models.Protobuf.Objects.DiscordGuildInfo info) => new DiscordGuildInfo(info);
    }
}
