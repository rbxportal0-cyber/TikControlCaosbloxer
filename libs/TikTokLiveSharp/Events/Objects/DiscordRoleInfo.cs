namespace TikTokLiveSharp.Events.Objects
{
    public sealed class DiscordRoleInfo
    {
        public string RoleId;
        public string RoleName;
        public string Permissions;
        public bool IsPositionAboveBot;
        public bool IsPermissionHigherBot;

        private DiscordRoleInfo(Models.Protobuf.Objects.DiscordRoleInfo info)
        {
            RoleId = info?.RoleIdStr ?? string.Empty;
            RoleName = info?.RoleName ?? string.Empty;
            Permissions = info?.Permissions ?? string.Empty;
            IsPositionAboveBot = info?.IsPositionAboveBot ?? false;
            IsPermissionHigherBot = info?.IsPermissionHigherBot ?? false;
        }

        public static implicit operator DiscordRoleInfo(Models.Protobuf.Objects.DiscordRoleInfo info) => new DiscordRoleInfo(info);
    }
}
