using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkmicUserToastContent
    {
        public readonly long UserId;
        public readonly long RoomId;
        public readonly Text DisplayText;

        private LinkmicUserToastContent(Models.Protobuf.Messages.LinkmicUserToastContent content)
        {
            UserId = content?.UserId ?? -1;
            RoomId = content?.RoomId ?? -1;
            DisplayText = content?.DisplayText;
        }

        public static implicit operator LinkmicUserToastContent(Models.Protobuf.Messages.LinkmicUserToastContent content) => new LinkmicUserToastContent(content);
    }
}
