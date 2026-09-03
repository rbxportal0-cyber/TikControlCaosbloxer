using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class PublicAreaCommon
    {
        public readonly Picture UserLabel;
        public readonly long UserConsumeInRoom;

        private PublicAreaCommon(Models.Protobuf.Messages.PublicAreaCommon pac)
        {
            UserLabel = pac?.UserLabel;
            UserConsumeInRoom = pac?.UserConsumeInRoom ?? -1;
        }

        public static implicit operator PublicAreaCommon(Models.Protobuf.Messages.PublicAreaCommon pac) => new PublicAreaCommon(pac);
    }
}
