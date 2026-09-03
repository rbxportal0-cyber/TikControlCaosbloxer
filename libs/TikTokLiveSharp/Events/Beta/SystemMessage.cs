namespace TikTokLiveSharp.Events.Beta
{
    public sealed class SystemMessage : AMessageData
    {
        public readonly string Message;

        internal SystemMessage(Models.Protobuf.UnknownObjects.SystemMessage msg)
            : base(msg?.Header)
        {
            Message = msg?.Message ?? string.Empty;
        }
    }
}