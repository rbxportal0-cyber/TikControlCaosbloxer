namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SOVBriefInfo
    {
        public readonly Picture Cover;
        public readonly SOVMaskInfo MaskInfo;

        private SOVBriefInfo(Models.Protobuf.Objects.SOVBriefInfo info)
        {
            Cover = info?.Cover;
            MaskInfo = info?.MaskInfo;
        }

        public static implicit operator SOVBriefInfo(Models.Protobuf.Objects.SOVBriefInfo info) => new SOVBriefInfo(info);
    }
}
