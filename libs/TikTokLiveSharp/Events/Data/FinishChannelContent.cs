using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class FinishChannelContent
    {
        public readonly Player Owner;
        public readonly long FinishReason;

        private FinishChannelContent(Models.Protobuf.Messages.FinishChannelContent content)
        {
            Owner = content?.Owner;
            FinishReason = content?.FinishReason ?? -1;
        }

        public static implicit operator FinishChannelContent(Models.Protobuf.Messages.FinishChannelContent content) => new FinishChannelContent(content);
    }
}
