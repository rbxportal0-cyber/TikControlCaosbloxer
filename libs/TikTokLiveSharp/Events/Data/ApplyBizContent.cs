using TikTokLiveSharp.Events.Objects;

namespace TikTokLiveSharp.Events.Data
{
    public sealed class ApplyBizContent
    {
        public readonly User User;

        private ApplyBizContent(Models.Protobuf.Messages.ApplyBizContent content)
        {
            User = content?.User;
        }

        public static implicit operator ApplyBizContent(Models.Protobuf.Messages.ApplyBizContent content) => new ApplyBizContent(content);
    }
}
