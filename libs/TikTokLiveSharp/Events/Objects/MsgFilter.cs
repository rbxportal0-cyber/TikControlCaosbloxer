namespace TikTokLiveSharp.Events.Objects
{
    public sealed class MsgFilter
    {
        public readonly bool IsGifter;
        public readonly bool IsSubscribedToHost;

        private MsgFilter(Models.Protobuf.Objects.MsgFilter filter)
        {
            IsGifter = filter?.IsGifter ?? false;
            IsSubscribedToHost = filter?.IsSubscribedToAnchor ?? false;
        }

        public static implicit operator MsgFilter(Models.Protobuf.Objects.MsgFilter filter) => new MsgFilter(filter);
    }
}
