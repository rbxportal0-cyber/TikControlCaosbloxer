namespace TikTokLiveSharp.Events.Objects
{
    public sealed class TopViewer
    {
        /// <summary>
        /// Rank for Viewer in List
        /// </summary>
        public readonly long Rank;

        /// <summary>
        /// Score for Viewer
        /// <para>
        /// Number of Coins given to Room
        /// </para>
        /// </summary>
        public readonly long Score;

        /// <summary>
        /// User
        /// </summary>
        public readonly User User;
        
        public readonly long Delta;

        private TopViewer(Models.Protobuf.Messages.RoomUserSeqMessage.Contributor viewer)
        {
            Rank = viewer?.Rank ?? -1;
            Score = viewer?.Score ?? -1;
            User = viewer?.User;
            Delta = viewer?.Delta ?? -1;
        }

        public static implicit operator TopViewer(Models.Protobuf.Messages.RoomUserSeqMessage.Contributor contributor) => new TopViewer(contributor);
    }
}