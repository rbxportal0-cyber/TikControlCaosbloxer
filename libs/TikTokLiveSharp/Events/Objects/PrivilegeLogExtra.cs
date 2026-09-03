namespace TikTokLiveSharp.Events.Objects
{
    public sealed class PrivilegeLogExtra
    {
        public readonly string DataVersion;
        public readonly string PrivilegeId;
        public readonly string PrivilegeVersion;
        public readonly string PrivilegeOrderId;
        public readonly string Level;

        private PrivilegeLogExtra(Models.Protobuf.Objects.PrivilegeLogExtra extra)
        {
            DataVersion = extra?.DataVersion ?? string.Empty;
            PrivilegeId = extra?.PrivilegeId ?? string.Empty;
            PrivilegeVersion = extra?.PrivilegeVersion ?? string.Empty;
            PrivilegeOrderId = extra?.PrivilegeOrderId ?? string.Empty;
            Level = extra?.Level ?? string.Empty;
        }

        public static implicit operator PrivilegeLogExtra(Models.Protobuf.Objects.PrivilegeLogExtra extra) => new PrivilegeLogExtra(extra);
    }
}
