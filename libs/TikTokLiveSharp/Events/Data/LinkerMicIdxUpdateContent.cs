namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerMicIdxUpdateContent
    {
        public readonly LinkerMicIdxUpdateInfo MicIdxUpdateInfo;
        
        private LinkerMicIdxUpdateContent(Models.Protobuf.Messages.LinkerMicIdxUpdateContent content)
        {
            MicIdxUpdateInfo = content?.MicIdxUpdateInfo;
        }

        public static implicit operator LinkerMicIdxUpdateContent(Models.Protobuf.Messages.LinkerMicIdxUpdateContent content) => new LinkerMicIdxUpdateContent(content);
    }
}
