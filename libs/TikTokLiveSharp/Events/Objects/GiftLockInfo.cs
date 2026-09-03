namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GiftLockInfo
    {
        public readonly bool Lock;
        public readonly int LockType;
        public readonly int GiftLevel;

        private GiftLockInfo(Models.Protobuf.Objects.GiftLockInfo info)
        {
            Lock = info?.Lock ?? false;
            LockType = info?.LockType ?? -1;
            GiftLevel = info?.GiftLevel ?? -1;
        }

        public static implicit operator GiftLockInfo(Models.Protobuf.Objects.GiftLockInfo info) => new GiftLockInfo(info);
    }
}
