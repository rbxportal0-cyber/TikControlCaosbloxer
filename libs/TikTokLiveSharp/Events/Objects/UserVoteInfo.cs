namespace TikTokLiveSharp.Events.Objects
{
    public sealed class UserVoteInfo
    {
        public readonly bool HasVoted;
        public readonly int VoteOptionIndex;

        private UserVoteInfo(Models.Protobuf.Objects.UserVoteInfo voteInfo)
        {
            HasVoted = voteInfo?.HasVoted ?? false;
            VoteOptionIndex = voteInfo?.VoteOptionIndex ?? -1;
        }

        public static implicit operator UserVoteInfo(Models.Protobuf.Objects.UserVoteInfo voteInfo) => new UserVoteInfo(voteInfo);
    }
}
