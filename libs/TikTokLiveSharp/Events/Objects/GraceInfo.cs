namespace TikTokLiveSharp.Events.Objects
{
    public sealed class GraceInfo
    {
        public readonly bool IsInGracePeriod;
        public readonly long GraceEndTime;

        private GraceInfo(Models.Protobuf.Objects.GraceInfo graceInfo)
        {
            IsInGracePeriod = graceInfo?.IsInGracePeriod ?? false;
            GraceEndTime = graceInfo?.GraceEndTime ?? -1;
        }

        public static implicit operator GraceInfo(Models.Protobuf.Objects.GraceInfo info) => new GraceInfo(info);
    }
}
