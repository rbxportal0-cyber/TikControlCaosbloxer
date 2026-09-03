using TikTokLiveSharp.Events.Linkmic;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class GroupChangeContent
    {
        public readonly GroupChannelAllUser GroupUser;

        private GroupChangeContent(Models.Protobuf.Messages.GroupChangeContent content)
        {
            GroupUser = content?.GroupUser;
        }

        public static implicit operator GroupChangeContent(Models.Protobuf.Messages.GroupChangeContent content) => new GroupChangeContent(content);
    }
}
