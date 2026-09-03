using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class CreateChannelContent
    {
        public readonly Player Owner;
        public readonly string OwnerLinkMicId;

        private CreateChannelContent(Models.Protobuf.Messages.CreateChannelContent content)
        {
            Owner = content?.Owner;
            OwnerLinkMicId = content?.OwnerLinkMicId ?? string.Empty;
        }

        public static implicit operator CreateChannelContent(Models.Protobuf.Messages.CreateChannelContent content) => new CreateChannelContent(content);
    }
}
