namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerSetting
    {
        public readonly long MaxMemberLimit;
        public readonly long LinkType;
        public readonly long Scene;
        public readonly long OwnerUserId;
        public readonly long OwnerRoomId;
        public readonly long Vendor;

        private LinkerSetting(Models.Protobuf.Messages.LinkerSetting setting)
        {
            MaxMemberLimit = setting?.MaxMemberLimit ?? -1;
            LinkType = setting?.LinkType ?? -1;
            Scene = setting?.Scene ?? -1;
            OwnerUserId = setting?.OwnerUserId ?? -1;
            OwnerRoomId = setting?.OwnerRoomId ?? -1;
            Vendor = setting?.Vendor ?? -1;
        }

        public static implicit operator LinkerSetting(Models.Protobuf.Messages.LinkerSetting info) => new LinkerSetting(info);
    }
}
