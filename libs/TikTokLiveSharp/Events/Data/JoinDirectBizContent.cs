namespace TikTokLiveSharp.Events.Data
{
    public sealed class JoinDirectBizContent
    {
        public readonly long ReplyImMsgId;

        private JoinDirectBizContent(Models.Protobuf.Messages.JoinDirectBizContent content)
        {
            ReplyImMsgId = content?.ReplyImMsgId ?? -1;
        }

        public static implicit operator JoinDirectBizContent(Models.Protobuf.Messages.JoinDirectBizContent content) => new JoinDirectBizContent(content);
    }
}
