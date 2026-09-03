using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class LinkerMuteContent
    {
        public readonly long UserId;
        public readonly MuteStatus Status;

        private LinkerMuteContent(Models.Protobuf.Messages.LinkerMuteContent content)
        {
            UserId = content?.UserId ?? -1;
            Status = content?.Status ?? MuteStatus.Mute;
        }

        public static implicit operator LinkerMuteContent(Models.Protobuf.Messages.LinkerMuteContent content) => new LinkerMuteContent(content);
    }
}
