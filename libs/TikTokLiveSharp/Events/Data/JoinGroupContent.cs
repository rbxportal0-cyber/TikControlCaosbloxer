using TikTokLiveSharp.Events.Linkmic;
using TikTokLiveSharp.Models.Protobuf.LinkmicCommon.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class JoinGroupContent
    {
        public readonly GroupChannelAllUser GroupUser;
        public readonly GroupPlayer JoinUser;
        public readonly JoinType Type;

        private JoinGroupContent(Models.Protobuf.Messages.JoinGroupContent content)
        {
            GroupUser = content?.GroupUser;
            JoinUser = content?.JoinUser;
            Type = content?.Type ?? JoinType.Join_Type_Unknown;
        }

        public static implicit operator JoinGroupContent(Models.Protobuf.Messages.JoinGroupContent content) => new JoinGroupContent(content);
    }
}
