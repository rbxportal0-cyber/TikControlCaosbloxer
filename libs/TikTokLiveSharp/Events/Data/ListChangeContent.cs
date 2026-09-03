using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.Messages.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ListChangeContent
    {
        public readonly ListChangeType Type;
        public readonly AllListUser List;

        private ListChangeContent(Models.Protobuf.Messages.ListChangeContent content)
        {
            Type = content?.Type ?? ListChangeType.List_Leave;
            List = content?.List;
        }

        public static implicit operator ListChangeContent(Models.Protobuf.Messages.ListChangeContent content) => new ListChangeContent(content);
    }
}
