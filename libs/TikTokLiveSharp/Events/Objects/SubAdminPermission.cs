namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubAdminPermission
    {
        public readonly bool AllowPinPerk;

        private SubAdminPermission(Models.Protobuf.Objects.SubAdminPermission permission)
        {
            AllowPinPerk = permission?.AllowPinPerk ?? false;
        }

        public static implicit operator SubAdminPermission(Models.Protobuf.Objects.SubAdminPermission permission) => new SubAdminPermission(permission);
    }
}
