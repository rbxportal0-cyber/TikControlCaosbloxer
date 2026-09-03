using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events
{
    public sealed class UnauthorizedMember : AMessageData
    {
        public readonly int Action;
        public readonly Text NickNamePrefix;
        public readonly string NickName;
        public readonly Text EnterText;

        internal UnauthorizedMember(Models.Protobuf.Messages.UnauthorizedMemberMessage msg)
            : base(msg?.Header)
        {
            Action = msg?.Action ?? -1;
            NickNamePrefix = msg?.NickNamePrefix;
            NickName = msg?.NickName ?? string.Empty;
            EnterText = msg?.EnterText;
        }
    }
}