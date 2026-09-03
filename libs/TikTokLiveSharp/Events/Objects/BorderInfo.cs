namespace TikTokLiveSharp.Events.Objects
{
    public sealed class BorderInfo
    {
        public readonly Picture Icon;
        public readonly long Level;
        public readonly string Source;
        public readonly Picture ProfileDecorationRibbon;
        public readonly PrivilegeLogExtra BorderPrivilegeLogExtra;
        public readonly PrivilegeLogExtra ProfilePrivilegeLogExtra;
        public readonly string AvatarBackgroundColor;
        public readonly string AvatarBackgroundBorderColor;

        private BorderInfo(Models.Protobuf.Objects.BorderInfo info)
        {
            Icon = info?.Icon;
            Level = info?.Level ?? -1;
            Source = info?.Source ?? string.Empty;
            ProfileDecorationRibbon = info?.ProfileDecorationRibbon;
            BorderPrivilegeLogExtra = info?.BorderPrivilegeLogExtra;
            ProfilePrivilegeLogExtra = info?.ProfilePrivilegeLogExtra;
            AvatarBackgroundColor = info?.AvatarBackgroundColor ?? string.Empty;
            AvatarBackgroundBorderColor = info?.AvatarBackgroundBorderColor ?? string.Empty;
        }

        public static implicit operator BorderInfo(Models.Protobuf.Objects.BorderInfo info) => new BorderInfo(info);
    }
}
