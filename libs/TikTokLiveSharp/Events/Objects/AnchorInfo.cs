namespace TikTokLiveSharp.Events.Objects
{
    public sealed class AnchorInfo
    {
        public readonly long Level;

        private AnchorInfo(Models.Protobuf.Objects.AnchorInfo anchorInfo)
        {
            Level = anchorInfo?.Level ?? -1;
        }

        public static implicit operator AnchorInfo(Models.Protobuf.Objects.AnchorInfo anchorInfo) => new AnchorInfo(anchorInfo);
    }
}
