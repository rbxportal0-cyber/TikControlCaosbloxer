using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Beta
{
    public sealed class QuestionNew : AMessageData
    {
        #region InnerTypes
        public sealed class QuestionDetails
        {
            public readonly ulong Id;
            public readonly string Text;
            public readonly ulong Timestamp;
            public readonly User User;
            public readonly uint Data20;

            private QuestionDetails(Models.Protobuf.UnknownObjects.QuestionNewMessage.QuestionDetails details)
            {
                Id = details?.Id ?? 0;
                Text = details?.Text ?? string.Empty;
                Timestamp = details?.Timestamp ?? 0;
                User = details?.User;
                Data20 = details?.Data20 ?? 0;
            }

            public static implicit operator QuestionDetails(Models.Protobuf.UnknownObjects.QuestionNewMessage.QuestionDetails details) => new QuestionDetails(details);
        }
        #endregion

        public readonly QuestionDetails Details;

        internal QuestionNew(Models.Protobuf.UnknownObjects.QuestionNewMessage msg)
            : base(msg?.Header)
        {
            Details = msg?.Data2;
        }
    }
}